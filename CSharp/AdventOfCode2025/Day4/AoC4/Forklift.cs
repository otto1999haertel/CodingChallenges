namespace AoC4;

public class Forklift
{
    public int CountAccessibleRolls(string[] input)
    {
        int accessibleRolls = 0;
        int localRools = 0;
        List<List<string>> grid = new List<List<string>>();
        foreach (string line in input)
        {
            grid.Add(line.Select(c => c.ToString()).ToList());
        }
        for (int i = 0; i < grid.Count; i++)
        {
            for (int j = 0; j < grid[i].Count; j++)
            {

                if (grid[i][j] == "@")
                {
                    localRools=0;
                    if (i - 1 >= 0 && j - 1 >= 0 && grid[i - 1][j - 1] == "@")
                    {
                        localRools++;
                    }
                    if (i - 1 >= 0 && grid[i - 1][j] == "@")
                    {
                        localRools++;
                    }
                    if (i - 1 >= 0 && j + 1 < grid[i].Count && grid[i - 1][j + 1] == "@")
                    {
                        localRools++;
                    }
                    if (j - 1 >= 0 && grid[i][j - 1] == "@")
                    {
                        localRools++;
                    }
                    if (j + 1 < grid[i].Count && grid[i][j + 1] == "@")
                    {
                        localRools++;
                    }
                    if (i + 1 < grid.Count && j - 1 >= 0 && grid[i + 1][j - 1] == "@")
                    {
                        localRools++;
                    }
                    if (i + 1 < grid.Count && grid[i + 1][j] == "@")
                    {
                        localRools++;
                    }
                    if (i + 1 < grid.Count && j + 1 < grid[i].Count && grid[i + 1][j + 1] == "@")
                    {
                        localRools++;
                    }
                    if(localRools<4)
                    {
                        localRools=0;
                        accessibleRolls++;
                    }
                }
            }
        }
        return accessibleRolls;
    }
}
