namespace AoC8;

internal static class PointDistanceCalculator
{
     internal static List<(Point3D p1, Point3D p2, double distance)> CreateSortedPairs(List<Point3D> points)
    {
        var pairs = new List<(Point3D, Point3D, double)>();
        
        // Alle Paare erstellen
        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                if(!points[i].Equals(points[j]))
                {
                    double dist = CalculateEuclideDistance(points[i], points[j]);
                    pairs.Add((points[i], points[j], dist));
                }

            }
        }
        
        // Nach Distanz sortieren
        pairs.Sort((a, b) => a.Item3.CompareTo(b.Item3));
        
        return pairs;
    }

    internal static double CalculateEuclideDistance(Point3D p1, Point3D p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        double dz = p2.Z - p1.Z;
    
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}