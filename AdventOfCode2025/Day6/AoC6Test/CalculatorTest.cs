using AoC6;

namespace AoC6Test;

public class CalculatorTest
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase("Task.txt", 4277556)]
    [TestCase("Task2.txt", 214016545)]
    public void Test1(string taskFile, int expected)
    {
        int result = _calculator.Calculate(taskFile);
        Assert.That(result.Equals(expected));
    }
}
