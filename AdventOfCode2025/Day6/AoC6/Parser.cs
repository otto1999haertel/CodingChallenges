using System.Text;

namespace AoC6;

internal class Parser{
    public TaskModel taskModel { get; private set; }
    private string filePath;

    public Parser(string FilePath)
    {
        if (!File.Exists(FilePath))
        {
            throw new FileNotFoundException("The specified file was not found.", FilePath);
        }
        filePath = FilePath;
    }

    public TaskModel Parse()
    {
        List<List<int>> data = new List<List<int>>();
        List<Operator> operators = new List<Operator>();

        using (var fileStream = File.OpenRead(filePath))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                if(line.Any(c => !char.IsDigit(c) && !char.IsWhiteSpace(c)))
                {
                    List<string> operatorsraw = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (string op in operatorsraw)
                    {
                        operators.Add(new Operator(op));
                    }
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
        taskModel = new TaskModel(data, operators);
        return taskModel;
    }
}