using System.Text;

namespace AoC5;

public class DataProcessor
{
    private readonly string _filePath;
    private readonly List<Range> ranges = new List<Range>();

    private readonly List<int> ingridientIds = new List<int>();
    public DataProcessor(string FilePath)
    {
        if (File.Exists(FilePath))
        {
            _filePath = FilePath;
            using (var fileStream = File.OpenRead(FilePath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128)) 
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains("-"))
                    {
                        string [] strings = line.Split('-');
                        Range range = new Range(int.Parse(strings[0]), int.Parse(strings[1]));
                        ranges.Add(range);
                    }
                    else if (string.IsNullOrEmpty(line)==false)
                    {
                        ingridientIds.Add(int.Parse(line));
                    }
                }
            }

        }
        else
        {
            throw new FileNotFoundException("The specified file was not found.", FilePath);
        }

    }

    public bool IsIngridientFresh(int id)
    {
        foreach(Range range in ranges)
        {
            if(range.Contains(id))
            {
                return true;
            }
        }
        return false;
    }

    public int CountFreshIngridients()
    {
        int freshCount = 0;
        foreach(int id in ingridientIds)
        {
            if(IsIngridientFresh(id))
            {
                freshCount++;
            }
        }
        return freshCount;
    }
}
