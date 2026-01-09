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
    public void Test1()
    {
        int result = _calculator.Calculate("Task.txt");
        Assert.That(result.Equals(4277556));
    }
}
