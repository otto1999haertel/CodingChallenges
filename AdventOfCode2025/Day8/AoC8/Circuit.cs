namespace AoC8;

internal class Circuit
{
    List<Point3D> points;

    public List<Point3D> Points { get { return points; } }
    public Circuit(Point3D pintA, Point3D pointB)
    {
        points = new List<Point3D> { pintA, pointB };
    }

    public void AddPoint(Point3D point)
    {
        points.Add(point);
    }

    public void Merge(Circuit otherCircuit)
    {
        foreach (var point in otherCircuit.Points)
        {
            if (!points.Contains(point))
            {
                points.Add(point);
            }
        }
    }
}