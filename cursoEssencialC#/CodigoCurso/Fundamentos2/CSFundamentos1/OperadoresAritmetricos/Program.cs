Console.WriteLine("\n ## Operadores Aritrimetricos ###");


Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();
//Console.WriteLine($"Soma de x + y = {x+y}");
//Console.WriteLine($"Subtração de x - y = {x - y}");
//Console.WriteLine($"Multiplicação de x * y = {x * y}");
//double divisao = (double)x / y;
//Console.WriteLine($"Divisão de x / y = {divisao}");
//Console.WriteLine($"Módulo ( resto da divisão)  de x % y = {x % y}");

// Usando a classe Math;

Console.WriteLine($"\n Raiz quadrada de x = {Math.Sqrt(x)} ");
Console.WriteLine($"\n Potencia de x elevado a Y = {Math.Pow(x,y)} ");
Console.WriteLine($"\n Valor minino entre x e y = {Math.Min(x,y)} ");
Console.WriteLine($"\n Valor máximo entre x e y = {Math.Max(x,y)} ");
Console.WriteLine($"\n Conseno de x = {Math.Cos(x)} ");
Console.WriteLine($"\n Seno de x = {Math.Sin(x)} ");
Console.WriteLine($"\n Exponencial de x = {Math.Exp(x)} ");





Console.ReadKey();
