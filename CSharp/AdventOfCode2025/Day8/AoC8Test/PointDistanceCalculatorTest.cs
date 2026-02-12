using AoC8;

namespace AoC8Test;

public class PointDistanceCalculatorTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateDistanceBetweenTwoPointsTest()
    {
        Point3D pointA = new Point3D(1, 2, 3);
        Point3D pointB = new Point3D(4, 5, 6);
        double distance = PointDistanceCalculator.CalculateEuclideDistance(pointA, pointB);
        Assert.That(distance.Equals(5.196152422706632));
    }

    [Test]
    public void CreateSortedPairsTest()
    {
        List<Point3D> points = new List<Point3D>
        {
            new Point3D(0, 0, 0),
            new Point3D(1, 1, 1),
            new Point3D(2, 2, 2)
        };

        var sortedPairs = PointDistanceCalculator.CreateSortedPairs(points);

        Assert.That(sortedPairs.Count == 3);
        Assert.That(sortedPairs[0].distance.Equals(sortedPairs[1].distance));
        Assert.That(sortedPairs[1].distance < sortedPairs[2].distance);
    }
}