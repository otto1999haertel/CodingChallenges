using AoC1;

namespace AoC1Test;

public class RotatorTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCaseSource(nameof(DirectionTestCases))]
    public void Test1(List<Direction> directions, int password)
    {
        Rotator rotator = new Rotator(directions);
        Assert.That(rotator.GetPassword().Equals(password));
    }

    private static IEnumerable<TestCaseData> DirectionTestCases()
    {
        yield return new TestCaseData(
            new List<Direction> { 
                new Direction(DirectionEnum.L,68),
                new Direction(DirectionEnum.L,30),
                new Direction(DirectionEnum.R,48),
                new Direction(DirectionEnum.L,5),
                new Direction(DirectionEnum.R,60),
                new Direction(DirectionEnum.L,55),
                new Direction(DirectionEnum.L,1),
                new Direction(DirectionEnum.L,99),
                new Direction(DirectionEnum.R,14),
                new Direction(DirectionEnum.L,82), },
            3
        ).SetName("Test with Up, Down, Left and password 3");
    }
}
