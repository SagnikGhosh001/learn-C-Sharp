List<string> names = ["<name>", "Ana", "Felipe"];
names.Add("Hi");


// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

var copyOfNames = names;
copyOfNames[0] = "chnaged";
Console.WriteLine(names[0]);
foreach (var name in copyOfNames)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}