using Advent2025;

Console.WriteLine("Hello, Advent of Code!");

var day = int.Parse(args[0]);

var partOne = day switch
{
    1 => Day01.PartOne(File.ReadAllText("Day01.txt")),
    2 => Day02.PartOne(File.ReadAllText("Day02.txt")),
    3 => Day03.PartOne(File.ReadAllText("Day03.txt")),
    4 => Day04.PartOne(File.ReadAllText("Day04.txt")),
    5 => Day05.PartOne(File.ReadAllText("Day05.txt")),
    6 => Day06.PartOne(File.ReadAllText("Day06.txt")),
    7 => Day07.PartOne(File.ReadAllText("Day07.txt")),
    8 => Day08.PartOne(File.ReadAllText("Day08.txt")),
    9 => Day09.PartOne(File.ReadAllText("Day09.txt")),
    10 => Day10.PartOne(File.ReadAllText("Day10.txt")),
    11 => Day11.PartOne(File.ReadAllText("Day11.txt")),
    12 => Day12.PartOne(File.ReadAllText("Day12.txt")),
    _ => throw new NotImplementedException(),
};

Console.WriteLine(partOne);


var partTwo = day switch
{
    1 => Day01.PartTwo(File.ReadAllText("Day01.txt")),
    2 => Day02.PartTwo(File.ReadAllText("Day02.txt")),
    3 => Day03.PartTwo(File.ReadAllText("Day03.txt")),
    4 => Day04.PartTwo(File.ReadAllText("Day04.txt")),
    5 => Day05.PartTwo(File.ReadAllText("Day05.txt")),
    6 => Day06.PartTwo(File.ReadAllText("Day06.txt")),
    7 => Day07.PartTwo(File.ReadAllText("Day07.txt")),
    8 => Day08.PartTwo(File.ReadAllText("Day08.txt")),
    9 => Day09.PartTwo(File.ReadAllText("Day09.txt")),
    10 => Day10.PartTwo(File.ReadAllText("Day10.txt")),
    11 => Day11.PartTwo(File.ReadAllText("Day11.txt")),
    12 => Day12.PartTwo(File.ReadAllText("Day12.txt")),
    _ => throw new NotImplementedException(),
};

Console.WriteLine(partTwo);
