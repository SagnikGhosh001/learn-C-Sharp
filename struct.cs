Point pt3 = new(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");

public record struct Point(int X, int Y);