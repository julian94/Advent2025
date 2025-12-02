namespace Advent;

public static class Day01
{
    public static string PartOne(string input)
    {
        var lines = input.Split("\n");
        var position = 50;
        var timesPositionWasZero = 0;

        foreach (var line in lines)
        {
            var regex = @"(?<direction>R|L)(?<count>\d+)";
            var match = Regex.Match(line, regex);
            if (match.Success)
            {
                var count = int.Parse(match.Groups["count"].Value);
                if (match.Groups["direction"].Value == "L")
                {
                    position -= count;
                }
                else
                {
                    position += count;
                }

                if (position % 100 == 0)
                {
                    timesPositionWasZero++;
                }
            }
        }
        return timesPositionWasZero.ToString();
    }

    public static string PartTwo(string input)
    {

        var lines = input.Split("\n");
        var position = 50;
        var timesPositionWasZero = 0;

        foreach (var line in lines)
        {
            var regex = @"(?<direction>R|L)(?<count>\d+)";
            var match = Regex.Match(line, regex);
            if (match.Success)
            {
                var count = int.Parse(match.Groups["count"].Value);
                if (match.Groups["direction"].Value == "L")
                {
                    for (var i = 0; i < count; i++)
                    {
                        position--;
                        if (position % 100 == 0)
                        {
                            timesPositionWasZero++;
                        }
                    }
                }
                else
                {
                    for (var i = 0; i < count; i++)
                    {
                        position++;
                        if (position % 100 == 0)
                        {
                            timesPositionWasZero++;
                        }
                    }
                }

            }
        }
        return timesPositionWasZero.ToString();
    }
}
