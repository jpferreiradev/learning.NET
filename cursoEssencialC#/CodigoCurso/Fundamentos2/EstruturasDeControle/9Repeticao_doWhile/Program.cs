using System.Collections.Concurrent;

Console.WriteLine("### Repetição do-while ###\n");

var i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;// Cuidado com o loop infinito
} while (i <= 10);


// Usando break;
Console.WriteLine();

var n = 1;
do
{
    Console.WriteLine($"n= {n}");
    n++;

    if (n > 7)
    {
        break;
    }

} while (n <= 10);


// instrução do-while aninhadas
Console.WriteLine();
int x = 0;

do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y})"); // Condição 2
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);


Console.ReadKey();
