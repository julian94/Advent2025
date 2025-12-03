namespace TestAdvent;

public class TestDay01
{
    [Test]
    public static void PartOne()
    {
        var exampleInput = """
        L68
        L30
        R48
        L5
        R60
        L55
        L1
        L99
        R14
        L82
        """;
        var exampleResult = "3";
        Assert.That(Day01.PartOne(exampleInput), Is.EqualTo(exampleResult));
    }

    [Test]
    public static void PartTwo()
    {
        var exampleInput = """
        L68
        L30
        R48
        L5
        R60
        L55
        L1
        L99
        R14
        L82
        """;
        var exampleResult = "6";
        Assert.That(Day01.PartTwo(exampleInput), Is.EqualTo(exampleResult));
    }
}