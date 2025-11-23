using Advent2025;

Console.WriteLine("Hello, Advent of Code!");

var day = int.Parse(args[0]);

var partOne = day switch
{
    1 => Day01.PartOne(File.ReadAllText("Day01.txt")),
    _ => throw new NotImplementedException(),
};

Console.WriteLine(partOne);


var partTwo = day switch
{
    1 => Day01.PartTwo(File.ReadAllText("Day01.txt")),
    _ => throw new NotImplementedException(),
};

Console.WriteLine(partTwo);
