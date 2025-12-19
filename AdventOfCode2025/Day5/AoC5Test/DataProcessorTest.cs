using AoC5;

namespace AoC5Test;

public class DataProcessorTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1, false)]
    [TestCase(5, true)]
    [TestCase(8, false)]
    [TestCase(11, true)]
    [TestCase(17, true)]
    [TestCase(32, false)]
    public void FreshNessTest(int id, bool expected)
    {
        DataProcessor dataProcessor = new DataProcessor("DataBase.txt");
        Assert.That(dataProcessor.IsIngridientFresh(id).Equals(expected));
    }
}
