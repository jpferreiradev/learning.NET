using System.Collections.Concurrent;

Console.WriteLine("### OPERADORES ARITMÉTRICOS\n");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());


// UTILIZANDO A CLASSE MATH
Console.WriteLine($"\n Raiz quadrada de x: {Math.Sqrt(x)}");
Console.WriteLine($"\n Potência de x elevado a y: {Math.Pow(x,y)} ");
Console.WriteLine($"\n Valor mínimo entre x e y: {Math.Min(x,y)}");
Console.WriteLine($"\n Valor máximo entre x e y: {Math.Max(x,y)}");
Console.WriteLine($"\n Conseno de x: {Math.Cos(x)}");
Console.WriteLine($"\n Seno de x: {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de x: {Math.Exp(x)}");

Console.ReadKey();
//Console.WriteLine($"SOMA =  {x+y}  ");
//Console.WriteLine($"SUBTRAÇÃO = {x-y}");
//Console.WriteLine($"MULTIPLICAÇÃO = {x * y}");
//double divisao = (double) x / y;
//Console.WriteLine($"DIVISÃO = {divisao}");
//Console.WriteLine($"MODULO ( RESTO DA DIVISÃO)  = {x % y}");