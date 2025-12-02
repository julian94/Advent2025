using Advent2025;
using NUnit.Framework;
namespace TestAdvent;

public class TestDay02
{
    [Test]
    public static void PartOne()
    {
        var exampleInput = """
        11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124
        """;
        var exampleResult = "1227775554";
        Assert.That(Day02.PartOne(exampleInput), Is.EqualTo(exampleResult));
    }

    [Test]
    public static void PartTwo()
    {
        var exampleInput = """
        11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124
        """;
        var exampleResult = "4174379265";
        Assert.That(Day02.PartTwo(exampleInput), Is.EqualTo(exampleResult));
    }
}