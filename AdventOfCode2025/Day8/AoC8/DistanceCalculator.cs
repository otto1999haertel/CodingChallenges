namespace AoC8;

public class DistanceCalculator
{
    private string filePath;
    public DistanceCalculator(string FilePath)
    {
        if (!File.Exists(FilePath))
        {
            throw new FileNotFoundException("The specified file was not found.", FilePath);
        }
        filePath = FilePath;
    } 
}
