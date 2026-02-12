using AoC8;

namespace AoC8Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("Task.txt", 4277556)]
    public void DistanceCalculateTest(string taskFile, int expected)
    {
        DistanceCalculator distanceCalculator = new DistanceCalculator(taskFile);
        distanceCalculator.CalculateDistances();
        Assert.Pass();
    }
}
