Console.WriteLine("### Repetição For 2 ###\n");

// Multiplas expressoes Loop For

//Acheei feio
//for(int i = 0, j = 0; i+j <= 20; i++,j++)
//{
//    Console.WriteLine($"i = {i} e j = {j}");
//}


// Outra forma, inicialização fora do loop e a interação dentro do loop
//int i = 1;
//for(; i <= 10;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

// outra forma

//int i = 1; // Loop for com o loop infinito
//for(; ; )
//{
//    Console.WriteLine($" i = {i}");
//    i++;
//}


for(int i = 0; i < 5; i++)
{
    for(int j = 0;  j < 5; j++)
    {
        Console.Write($" ({i},{j})" );
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Fim do processamento...");
Console.ReadKey();
