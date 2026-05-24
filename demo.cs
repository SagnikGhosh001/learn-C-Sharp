// using System;
// using System.Globalization;

// namespace MyApp.Services;

// class Greeter
// {
//   static void Main()
//   {
//     var culture = CultureInfo.CurrentCulture;
//     Console.WriteLine($"Hello, Sagnik! Culture: {culture.Name}");
//   }
// }

string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
return returnValue;