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

    public int CalculateDistances()
    {
        //Connecting two points allows floating current
        //connected point build a circuit
        //Goal: save cable => just connect two nearest points, which are not connected yet
        //1. Calculate shortest distance between all point pairs
        //   => Connect the closest pair and form one circuit

        //2. Repeat: Find the next shortest distance between any two points
        //   (regardless of whether they are already in a circuit or not)

        //3. Check which circuits the two points belong to:
        //   - If DIFFERENT circuits => MERGE the circuits
        //   - If SAME circuit => Do nothing (but count this connection)

        //Resul: Multiplication of distance of three biggest circuits
        int totalDistance = 0;
        List<Point3D> points = new Parser(filePath).ParseInput();
        List<(Point3D, Point3D,double)> calculatedList = PointDistanceCalculator.CreateSortedPairs(points);
        return totalDistance;
    } 
}
