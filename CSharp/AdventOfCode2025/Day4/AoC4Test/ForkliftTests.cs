using AoC4;

namespace AoC4Test;

public class ForkliftTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CountAccisbleRoolsTest()
    {
        // Arrange
        string[] input = new[]
        {
            "..@@.@@@@.",
            "@@@.@.@.@@",
            "@@@@@.@.@@",
            "@.@@@@..@.",
            "@@.@@@@.@@",
            ".@@@@@@@.@",
            ".@.@.@.@@@",
            "@.@@@.@@@@",
            ".@@@@@@@@.",
            "@.@.@@@.@."
        };
        int expected = 13;
        Forklift forklift = new Forklift();
        Assert.That(forklift.CountAccessibleRolls(input), Is.EqualTo(expected));
    }
}
