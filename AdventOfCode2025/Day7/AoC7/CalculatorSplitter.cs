namespace AoC7;
public class CalculatorSplitter
{
    private char[,]input;
    public CalculatorSplitter(char[,]Input)
    {
        input = Input;
    }

    public int CalculateSumOfSplits()
    {
        // Placeholder implementation
        int splitCount = 0;
        for(int i = 1; i < input.GetLength(0); i++)
        {
            for(int j = 0; j < input.GetLength(1); j++)
            {
                if(input[i-1,j] == 'S' || input[i-1,j] == '|')
                {
                    input[i,j]='|';
                    splitCount++;
                }
                if(i>0 && i<=input.GetLength(0) && j>0 && j<input.GetLength(1)-1)
                {
                    if(input[i,j]=='^')
                    {
                        input[i-1,j]='|';
                        input[i+1,j] = '|';
                        splitCount+=2;
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
            for(int j = 0; j < input.GetLength(1); j++)
            {
                Console.Write(input[i,j]);
            }
            Console.WriteLine();
        }
    }
}