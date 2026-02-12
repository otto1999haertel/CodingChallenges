namespace AoC2;

public class IDChecker
{
    public int CheckIDs(string input)
    {
        // Implementation goes here
        int result =0;
        List<string> idRanges = input.Split(',').ToList();
        foreach(string id in idRanges)
        {
            int lowerBound = int.Parse(id.Split('-')[0]);
            int upperBound = int.Parse(id.Split('-')[1]);
            for(int i=lowerBound; i<=upperBound; i++)
            {
                string idStr = i.ToString();
                if (idStr.Count() % 2 == 0)
                {
                    int middle = idStr.Length / 2;
                    string firstHalf = idStr.AsSpan(0, middle).ToString();
                    string secondHalf = idStr.AsSpan(middle).ToString();
                    if(firstHalf.Equals(secondHalf))
                    {
                        result += i;
                    }
                }
            }
        }
        return result;
    }
}
