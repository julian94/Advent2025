namespace Advent;

public static class Day02
{
    public static string PartOne(string input)
    {
        var ranges = input.Split(",");
        long sum = 0;

        foreach (var line in ranges)
        {
            var regex = @"(?<start>\d+)-(?<end>\d+)";
            var match = Regex.Match(line, regex);
            if (match.Success)
            {
                var start = long.Parse(match.Groups["start"].Value);
                var end = long.Parse(match.Groups["end"].Value);
                for (long i = start; i <= end; i++)
                {
                    if (IsDoubled(i.ToString()))
                    {
                        sum += i;
                    }
                }
            }
        }
        return sum.ToString();
    }

    public static string PartTwo(string input)
    {
        var ranges = input.Split(",");
        long sum = 0;

        foreach (var line in ranges)
        {
            var regex = @"(?<start>\d+)-(?<end>\d+)";
            var match = Regex.Match(line, regex);
            if (match.Success)
            {
                var start = long.Parse(match.Groups["start"].Value);
                var end = long.Parse(match.Groups["end"].Value);
                for (long i = start; i <= end; i++)
                {
                    if (HasRepeatingParts(i.ToString()))
                    {
                        sum += i;
                    }
                }
            }
        }
        return sum.ToString();
    }


    private static bool IsDoubled(string number)
    {
        if (number.Length % 2 == 1) return false;

        var parts = number.AsSpan();
        var half = parts.Length / 2;
        for (var i = 0; i < half; i++) if (parts[i] != parts[i + half]) return false;

        return true;
    }

    private static bool HasRepeatingParts(string number)
    {
        var parts = number.AsSpan();
        var half = number.Length / 2;
        for (var i = 0; i < half; i++)
        {
            var substring = number.Substring(0, i + 1);
            var testString = substring;
            for (var j = 0; j < 10; j++)
            {
                testString += substring;
                if (testString == number) return true; 
            }
        }

        return false;
    }

}
