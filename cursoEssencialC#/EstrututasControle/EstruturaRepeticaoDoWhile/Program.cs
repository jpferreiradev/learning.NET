Console.WriteLine("### Estrutura repetição DO-While ###\n");

var i = 1;

//do
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}
//while (i <= 10);

//Console.WriteLine();
// Usando o Break;

//do
//{
//    Console.WriteLine($"i = {i}");
//    Console.WriteLine($"i = {i}");
//    i++;

//    if(i > 7)
//    {
//        break;
//    }
//}
//while (i <= 10);

Console.WriteLine("Exemplo do-while aninhado");

int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y})");
        y++; // se não entra em loop
    }
    while (y < 5);
    x++; // se não entra em loop
    Console.WriteLine();

}
while (x < 5);


Console.ReadKey();
