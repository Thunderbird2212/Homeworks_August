Console.Write("Enter b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());


var x = (b2 - b1) / (k1 - k2);
var y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Cross point: ({x}; {y})");
