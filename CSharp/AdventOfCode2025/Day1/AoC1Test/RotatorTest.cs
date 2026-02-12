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

        // Startet bei 50, nie bei 0
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 10),
            new Direction(DirectionEnum.L, 20)
            },
            0
        ).SetName("Never hits 0");

        // Direkt auf 0 bei erster Rotation
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.L, 50)
            },
            1
        ).SetName("Hits 0 immediately with L50");

        // Direkt auf 0 bei erster Rotation (anderer Weg)
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 50)
            },
            1
        ).SetName("Hits 0 immediately with R50");

        // Mehrfach über 0 hinweg
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 50),  // 50 -> 0
            new Direction(DirectionEnum.R, 100), // 0 -> 0 (volle Runde)
            new Direction(DirectionEnum.L, 100)  // 0 -> 0 (volle Runde zurück)
            },
            3
        ).SetName("Multiple full rotations through 0");

        // Volle Runde (100 Klicks)
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 100)
            },
            0
        ).SetName("Full rotation right (100 clicks)");

        // Von 5 nach links über 0 (aus Beispiel)
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.L, 55),  // 50 -> 95
            new Direction(DirectionEnum.R, 10),  // 95 -> 5
            new Direction(DirectionEnum.L, 10)   // 5 -> 95 (über 0)
            },
            0
        ).SetName("From 5 left 10 to 95 crossing 0");

        // Von 95 nach rechts über 0
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.L, 55),  // 50 -> 95
            new Direction(DirectionEnum.R, 5)    // 95 -> 0
            },
            1
        ).SetName("From 95 right 5 to 0");

        // Mehrfach hin und her über 0
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 50),  // 50 -> 0
            new Direction(DirectionEnum.R, 50),  // 0 -> 50
            new Direction(DirectionEnum.L, 50),  // 50 -> 0
            new Direction(DirectionEnum.L, 50),  // 0 -> 50
            new Direction(DirectionEnum.R, 50)   // 50 -> 0
            },
            3
        ).SetName("Multiple crossings back and forth");

        // Leere Liste
        yield return new TestCaseData(
            new List<Direction>(),
            0
        ).SetName("Empty rotation list");

        // Einzelne Rotation, die 0 nicht trifft
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 10)
            },
            0
        ).SetName("Single rotation not hitting 0");

        // Grenzfall: Genau eine Zahl vor 0
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.R, 49),  // 50 -> 99
            new Direction(DirectionEnum.R, 1)    // 99 -> 0
            },
            1
        ).SetName("Ending exactly at 0 from 99");

        // Mehrere kleine Schritte über 0
        yield return new TestCaseData(
            new List<Direction> {
            new Direction(DirectionEnum.L, 48),  // 50 -> 2
            new Direction(DirectionEnum.L, 2),   // 2 -> 0
            new Direction(DirectionEnum.L, 1),   // 0 -> 99
            new Direction(DirectionEnum.R, 99)   // 99 -> 98... nein, 99+99=198%100=98
            },
            1
        ).SetName("Small steps crossing 0");
    }
}
