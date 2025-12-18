using AoC3;

namespace AoC3Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCaseSource(nameof(JoltageTestCases))]
    public void CalculateJoltageTest(List<string> input, int outPutJolate)
    {
        BatteryManagement batteryManagement = new BatteryManagement();
        Assert.That(batteryManagement.CalculateJolate(input).Equals(outPutJolate));
    }

    private static IEnumerable<TestCaseData> JoltageTestCases()
    {
        // Beispiel aus der Aufgabe
        yield return new TestCaseData(
            new List<string> {
            "987654321111111",
            "811111111111119",
            "234234234234278",
            "818181911112111"
            },
            357
        ).SetName("Example from puzzle - total 357");

        // Einzelne Bank Tests
        yield return new TestCaseData(
            new List<string> { "98" },
            98
        ).SetName("Single bank with two batteries - 98");

        yield return new TestCaseData(
            new List<string> { "12345" },
            45
        ).SetName("Single bank 12345 - max is 45");

        yield return new TestCaseData(
            new List<string> { "99" },
            99
        ).SetName("Single bank - maximum possible 99");

        yield return new TestCaseData(
            new List<string> { "11" },
            11
        ).SetName("Single bank - minimum valid 11");

        // Alle gleichen Ziffern
        yield return new TestCaseData(
            new List<string> { "5555555" },
            55
        ).SetName("All same digits - any two give 55");

        yield return new TestCaseData(
            new List<string> { "9999999" },
            99
        ).SetName("All 9s - maximum 99");

        // Aufsteigende und absteigende Sequenzen
        yield return new TestCaseData(
            new List<string> { "123456789" },
            89
        ).SetName("Ascending sequence - max is 89");

        yield return new TestCaseData(
            new List<string> { "987654321" },
            98
        ).SetName("Descending sequence - max is 98");

        // Mehrere Banken mit verschiedenen Mustern
        yield return new TestCaseData(
            new List<string> {
            "99",
            "88",
            "77"
            },
            99 + 88 + 77
        ).SetName("Multiple banks with descending maximums");

        yield return new TestCaseData(
            new List<string> {
            "191919191",
            "282828282",
            "373737373"
            },
            99 + 88 + 77
        ).SetName("Alternating patterns");

        // 9 am Anfang, aber besser am Ende
        yield return new TestCaseData(
            new List<string> { "912345678" },
            98
        ).SetName("9 at start ");

        // 9 irgendwo in der Mitte
        yield return new TestCaseData(
            new List<string> { "123945678" },
            98
        ).SetName("9 in middle - still 89 is best");

        // Nur kleine Zahlen
        yield return new TestCaseData(
            new List<string> { "11111122222" },
            22
        ).SetName("Small numbers only - max is 22");

        yield return new TestCaseData(
            new List<string> { "811111119" },
            89
        ).SetName("8 at start, 9 at end - 89 is best");

        // Edge Case: Genau zwei Batterien
        yield return new TestCaseData(
            new List<string> {
            "12",
            "98",
            "45"
            },
            12 + 98 + 45
        ).SetName("Banks with exactly two batteries each");

        // Viele Einsen mit zwei hohen Zahlen
        yield return new TestCaseData(
            new List<string> { "711111119" },
            79
        ).SetName("7 and 9 with ones between");

        // Komplexes Beispiel mit mehreren Banken
        yield return new TestCaseData(
            new List<string> {
            "123456789",  // 89
            "987654321",  // 98
            "555555555",  // 55
            "191919191",  // 99
            "999999999"   // 99
            },
            89 + 98 + 55 + 99 + 99
        ).SetName("Complex example with various patterns");

        // Lange Bank mit 9en an verschiedenen Stellen
        yield return new TestCaseData(
            new List<string> { "91111111111119" },
            99
        ).SetName("Long bank with two 9s at different positions - 99 at end is best");

        // Mittlere Zahlen
        yield return new TestCaseData(
            new List<string> { "444555666" },
            66
        ).SetName("Middle range numbers - 66 is maximum");

        // Leere Liste (Edge Case)
        yield return new TestCaseData(
            new List<string>(),
            0
        ).SetName("Empty list - should return 0");

        // Viele Banken mit Minimum
        yield return new TestCaseData(
            new List<string> {
            "1111",
            "2222",
            "3333"
            },
            11 + 22 + 33
        ).SetName("Multiple banks with repeating low digits");
    }

}
