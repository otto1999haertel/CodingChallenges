using AoC2;

namespace AoC2Test;

public class IDCheckerTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCaseSource(nameof(IDCheckerTestCases))]
    public void Test1(string input, int additionOfAllInvalidIDs)
    {
        IDChecker idChecker = new IDChecker();
        Assert.That(idChecker.CheckIDs(input).Equals(additionOfAllInvalidIDs));
    }

    private static IEnumerable<TestCaseData> IDCheckerTestCases()
    {
        yield return new TestCaseData(
            "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124",
            1227775554
        ).SetName("Test with example input");
    }
}
