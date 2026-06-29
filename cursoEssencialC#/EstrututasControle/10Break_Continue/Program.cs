Console.WriteLine("\n ### Estrutura breack e continue ");

//for(; ; )
//{
//    Console.WriteLine("Tecle algo ( x sai) ");
//    var opcao = Console.ReadLine();

//    Console.WriteLine(opcao.ToUpper()); // Imprimir em caixa alta

//   if(opcao == "X" || opcao == "x")
//    {
//        Console.WriteLine("Xau...");
//        break;
//    }

//}

//Console.WriteLine(" ----- Exemplo continue");

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 4)
//        continue;

//    Console.WriteLine(i);

//}

Console.WriteLine("\n--- EXEMPLO LOOP WHILE ---");

//int n = 1;
//while (n <= 10)
//{
//    if( n == 5)
//    {
//        n++;
//        continue;
//    }
//    Console.WriteLine($"n = {n}");
//    n++;
//}

Console.WriteLine("\n ###Usando continue e break na mesma interação##");

for(int i = 0; i < 10; i++)
{
    if (i == 5)
        continue;

    if (i > 8)
        break;

    Console.WriteLine(i);
}
Console.ReadKey();
