namespace Advent;

public static class Day03
{
    public static string PartOne(string input) => Generic(input, 2);

    public static string PartTwo(string input) => Generic(input, 12);

    public static string Generic(string input, int batteries)
    {
        var batteriesMinusOne = batteries - 1;
        var ranges = input.Replace("\r", "").Split("\n");
        long sum = 0;

        foreach (var line in ranges)
        {
            if (string.IsNullOrEmpty(line)) continue;
            var numbers = line.Select(d => int.Parse($"{d}")).ToList();
            List<int> result = [.. numbers.Take(batteries)];
            foreach (var number in numbers.Skip(batteries))
            {
                for (var i = 0; i < batteries; i++)
                {
                    if (i == batteriesMinusOne && number > result[i])
                    {
                        result[i] = number;
                    }
                    else if (i == batteriesMinusOne)
                    {
                        continue;
                    }
                    else if (result[i + 1] > result[i])
                    {
                        for (; i < batteriesMinusOne; i++)
                        {
                            result[i] = result[i + 1];
                        }
                        result[batteriesMinusOne] = number;
                        break;
                    }
                }
            }

            result.Reverse();
            long multiplier = 1;
            long lineSum = 0;
            foreach (var number in result)
            {
                lineSum += number * multiplier;
                multiplier *= 10;
            }
            sum += lineSum;
        }
        return sum.ToString();
    }
}
