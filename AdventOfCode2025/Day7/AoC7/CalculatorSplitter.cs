namespace AoC7;
public class CalculatorSplitter
{
    private char[][]input;
    public CalculatorSplitter(char[][]Input)
    {
        input = Input;
    }

    public int CalculateSumOfSplits()
    {
        // Placeholder implementation
        int splitCount = 0;
        for(int i = 1; i < input.GetLength(0); i++)
        {
            for(int j = 0; j < input[j].Count(); j++)
            {
                if(!input[i][j].Equals('^') && (input[i-1][j].Equals('S') || input[i - 1][j].Equals('|')))
                {
                    input[i][j]='|';
                }
                if(i>0 && i<=input.GetLength(0) && j>0 && j<input[i].Count()-1)
                {
                    if(input[i][j].Equals('^'))
                    {
                        splitCount++;
                        if (!input[i][j - 1].Equals('|'))
                        {
                            input[i][j - 1] = '|';
                        }
                        if(!input[i][j + 1].Equals('|'))
                        {
                            input[i][j + 1] = '|';
                        }
                        
                    }
                }
            }
        }
        PrintInput();
        return splitCount;
    }

    public void PrintInput()
    {
        for(int i = 0; i < input.GetLength(0); i++)
        {
            for(int j = 0; j <  input[j].Count(); j++)
            {
                Console.Write(input[i][j]);
            }
            Console.WriteLine();
        }
    }
}