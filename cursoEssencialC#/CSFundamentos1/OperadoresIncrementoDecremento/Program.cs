Console.WriteLine("\n ### OPERADORES INCREMENTO E DECREMENTO ###");

int x = 0;
x++;
Console.WriteLine(x);
x--;
Console.WriteLine(x);

Console.WriteLine("--- PÓS-INCREMENTO ---");
Console.WriteLine($"x = {x}");

int resultado = x++ + 10;

Console.WriteLine($"Pos incremento = {resultado}");
Console.WriteLine($"Valor de x ==> {x}\n");

Console.WriteLine("--- Pré-INCREMENTO ---");
int y = 0;
Console.WriteLine($"y = {y}");

int resultado2 = ++y + 10;

Console.WriteLine($"Preé incremento = {resultado2}");
Console.WriteLine($"Valor de y ==> {y}\n");

Console.WriteLine("----------------------- ( -- DECREMENTO ) --------");

int d = 0;
x++;
Console.WriteLine(d);
x--;
Console.WriteLine(d);

Console.WriteLine("--- PÓS-DECREMNTO---");
Console.WriteLine($"x = {d}");

int resultado3 = d-- + 10;

Console.WriteLine($"Pos incremento = {resultado}");
Console.WriteLine($"Valor de d ==> {d}\n");

Console.WriteLine("--- Pré-INCREMENTO ---");
int z = 0;
Console.WriteLine($"y = {z}");

int resultado4 = --z + 10;

Console.WriteLine($"Preé incremento = {resultado4}");
Console.WriteLine($"Valor de y ==> {z}\n");

Console.ReadLine();