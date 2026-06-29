using System.Globalization;

Console.WriteLine("\n ### ESTRUTURA FOR ## ");


//int numero, resultado;

//Console.WriteLine("Informe um número: ");
//numero = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O número informado foi: {numero}");

//Console.WriteLine();
//for (int i = 1; i <= 10; i++)
//{
//    resultado = numero * i;
//    Console.WriteLine($"{numero} x {i} = {resultado}");
//}

//Console.WriteLine(" --- Multiplas expressões ----"); // Achei banaca! 
//Console.WriteLine();

//for(int i = 0, j = 0; i + j <= 20; i++, j++)
//{
//    Console.WriteLine($"i = {i} e j = {j}");
//}

//Console.WriteLine("---- Outro exemplo");

//int i = 1;
//for(; i <= 10;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//Console.WriteLine("\n---Outro exemplo ----");

//int j = 1;
//for(; ; )
//{
//    Console.WriteLine($"i = {j}");
//}

Console.WriteLine("\n --- FOR ANINHADOS ---");

for(int x = 0; x < 5; x++)
{
    for(int y = 0; y < 5; y++)
    {
        Console.Write($"({x}, {y})");
    }
    Console.WriteLine();
}
 
Console.ReadKey();
