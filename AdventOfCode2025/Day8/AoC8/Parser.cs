using System.Text;

internal class Parser
{
    private string filePath;

    public Parser(string FilePath)
    {
        if (!File.Exists(FilePath))
        {
            throw new FileNotFoundException("The specified file was not found.", FilePath);
        }
        filePath = FilePath;
    }
    public List<Point> ParseInput()
    {
        List<Point> points = new List<Point>();
        using (var fileStream = File.OpenRead(filePath))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] strings = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (strings.Length != 3)
                {
                    throw new FormatException("Each line must contain exactly three comma-separated values.");
                }

                if (int.TryParse(strings[0], out int x) &&
                    int.TryParse(strings[1], out int y) &&
                    int.TryParse(strings[2], out int z))
                {
                    points.Add(new Point(x, y, z));
                }
                else
                {
                    throw new FormatException("All values must be valid integers.");
                }
            }
        }

        return points;
    }
}