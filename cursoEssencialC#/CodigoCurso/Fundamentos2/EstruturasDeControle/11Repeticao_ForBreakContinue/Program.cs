Console.WriteLine("### Repetição For - Break and Continue");


// Usando break

//for (; ; )
//{
//    Console.Write("Tecle algo (x sai): ");
//    var opcao = Console.ReadLine();

//    Console.WriteLine(opcao.ToUpper());

//    if(opcao == "X" ||  opcao == "x")
//    {
//        Console.WriteLine("Tchauu...");
//        break;
//    }
//}

//Console.WriteLine();
//Console.WriteLine();
//// Usando continue

//for(int i = 1; i<= 10; i++) // O 4 não vai mostrar
//{
//    if(i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//// Exemplo com loop while
//Console.WriteLine();

//int n = 1;
//while(n <= 10)
//{
//    if (n == 5)
//    {
//        n++; // É preciso ter, se não ele vai parar
//        continue; // ele vai retornar pra condicao, ver se n é = 10, e vai para o 6;
//    }
//    Console.WriteLine($"n = {n}");
//    n++;
//}

// Usando continue e break no mesmo loop
   
for(int i = 1; i <= 10; i++)
{
    if(i == 5)
    {
        continue;
    }
    if(i > 8)
    {
        break;
    }
    Console.WriteLine($"{i}");
}

Console.ReadKey();
