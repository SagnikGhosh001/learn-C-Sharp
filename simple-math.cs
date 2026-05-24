int x = 20;
int y = 15;
byte z = 255;
z += 1;
Console.WriteLine(x / y);
Console.WriteLine(z);



int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");


double third = 1.0 / 3.0;
Console.WriteLine(third);


int a = 10;
int b = 3;
double c = (double)a / (double)b;
Console.WriteLine(c);