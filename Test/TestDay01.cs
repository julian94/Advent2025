using Advent2025;
using NUnit.Framework;
namespace TestAdvent2025;

public class TestDay01Part1
{
    [Test]
    public static void MatchesExample()
    {
        var exampleInput = """

        """;
        var exampleResult = "";
        Assert.That(Day01.PartOne(exampleInput), Is.EqualTo(exampleResult));
    }
}

public class TestDay01Part2
{
    [Test]
    public static void MatchesExample()
    {
        var exampleInput = """

        """;
        var exampleResult = "";
        Assert.That(Day01.PartTwo(exampleInput), Is.EqualTo(exampleResult));
    }
}