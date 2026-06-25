using System.Collections.Concurrent;

Console.WriteLine("## OPERADORES DE ATRIBUIÇÃO ##\n");

// Usando operadores de atribuição com tipos númericos

var x = 10;
x = 20;


Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($" x+= 5 ==> {x += 5}");
Console.WriteLine($" x-= 3 ==> {x -= 3}");
Console.WriteLine($" x*= 4 ==> {x *= 4}");
Console.WriteLine($" x/= 5 ==> {x /= 5}");
Console.WriteLine($" x%= 5 ==> {x %= 5}");

Console.WriteLine("\n-------- String -------");

string y = null;

Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y+=\"456\" ==> {y+"456"}");


Console.ReadLine();

