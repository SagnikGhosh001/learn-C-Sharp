// Point pt3 = new(1, 1);
// var pt4 = pt3 with { Y = 10 };
// Console.WriteLine($"The two points are {pt3} and {pt4}");

// public record struct Point(int X, int Y);


// Point p = new Point { X = 10 };
// Console.WriteLine(p.X);

// struct Point
// {
//   public int X
//   {
//     get
//     {
//       Y = 10;
//       return Y;
//     }
//     set => Y = value;
//   }
//   public int Y { get; set; }
// }


var c = new Counter();
c.Increment();
Console.WriteLine(c.Value);

struct Counter
{
  public readonly int Value { readonly get; }
  public int Value2 { get; private set; }

  public void Increment()
  {
    Value2++;
  }
}