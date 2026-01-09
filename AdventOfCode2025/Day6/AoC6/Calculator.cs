using System.Text;

namespace AoC6;

public class Calculator
{
    public Calculator()
    {

    }

    public int Calculate(string FilePath)
    {
        // Implementation goes here
        List<List<int>> data = new List<List<int>>(); 
        List<string> operators = new List<string>();
        if (!File.Exists(FilePath))
        {
            throw new FileNotFoundException("The specified file was not found.", FilePath);
        }
        using (var fileStream = File.OpenRead(FilePath))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                if(line.Any(c => !char.IsDigit(c) && !char.IsWhiteSpace(c)))
                {
                    operators = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    break;
                }
                string[] strings = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                List<int> row = new List<int>();
                foreach (string str in strings)
                {
                    if (str != "*")
                    {
                        row.Add(int.Parse(str));
                    }
                    else
                    {
                        row.Add(0);
                    }
                }
                data.Add(row);
            }
        }
        SemanticCheck(data, operators);
        OperatorCheck(operators);
        int res = PerformAddition(data, operators);
        return res;
    }

    private void SemanticCheck(List<List<int>> data, List<string> operators)
    {
        foreach(var row in data)
        {
            if(row.Count != operators.Count)
            {
                throw new ArgumentException("The number of columns in data does not match the number of operators.");
            }
        }
    }

    private void OperatorCheck(List<string> operators)
    {
        if(operators.Any(op => op != "+" && op != "*" && op != "-" && op != "/"))
        {
            throw new ArgumentException("Invalid operator found. Only '+' and '*' are allowed.");
        }
    }

    private int PerformAddition(List<List<int>> data, List<string> operators)
    {
        int result =0; 
        for(int i=0; i<operators.Count;i++)
        {
            List<int> column = GetColumn(data, i);
            if(operators[i] == "+")
            {
                result+=column.Sum();
                continue;
            }
            if(operators[i]  == "*")
            {
                int produkt = column.Aggregate((a, b) => a * b);
                result+=produkt;
                continue;
            }
            if(operators[i]  == "-")
            {
                 int subtractation = column.Aggregate((a, b) => a - b);
                 result+=subtractation;
                 continue;
            }
            if(operators[i]  == "/")
            {
                double division = column.Aggregate((a, b) => a / b);
                result+= (int)division;
                continue;
            }
        }   

        return result;
    }

    private List<int> GetColumn(List<List<int>> data, int columnIndex)
    {
        List<int> column = new List<int>();
        foreach(var row in data)
        {
            column.Add(row[columnIndex]);
        }
        return column;
    }
}
