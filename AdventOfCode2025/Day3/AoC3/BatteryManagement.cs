namespace AoC3;

public class BatteryManagement
{
    public int CalculateJolate(List<string> input)
    {
        // Implementation goes here
        int result =0; 
        foreach(string line in input)
        {
            // Dummy calculation for illustration
            int firstDigit = 0;
            int secndDigit =0;
            int.TryParse(line[0].ToString(), out firstDigit);
            for(int i=0; i<line.Length;i++)
            {
                if(i<line.Length-1 && int.TryParse(line[i].ToString(), out int digit))
                {
                    if(i!=line.Length-1 && digit>firstDigit)
                    {
                        firstDigit = digit;
                        secndDigit=0;
                        continue;
                    }
                    if(firstDigit!=0 && i != 0)
                    {
                        if(int.TryParse(line[i].ToString(), out int digit2))
                        {
                            if(digit2>secndDigit || digit2==9)
                            {
                                secndDigit = digit2;
                            } 
                        }
                    }
                }
                else
                {
                    if(int.TryParse(line[i].ToString(), out int digit2))
                        {
                            if(digit2>secndDigit || digit2==9)
                            {
                                secndDigit = digit2;
                            } 
                        }
                }
                if(firstDigit==9 && secndDigit==9)
                {
                    break;
                }
            }
            int.TryParse(firstDigit.ToString() + secndDigit.ToString(), out int jolate);
            result += jolate;
        }
        return result;
    }
}
