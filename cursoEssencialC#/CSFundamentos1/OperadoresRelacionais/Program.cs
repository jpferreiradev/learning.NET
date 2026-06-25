using System.Globalization;

Console.WriteLine("##\n OPERADORS RELACIONAIS ##");

int x = 10;
int y = 20;


Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de y {y}");

//Console.WriteLine(x == y);
//bool resultado = x == y;
//Console.WriteLine(resultado);

Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

Console.WriteLine("\n ====== STRINGS ===== ");

string a = "Curso";
string b = "curso";

Console.WriteLine($"Valor de A  {a}");
Console.WriteLine($"Valor de B {b}");

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));




Console.WriteLine();