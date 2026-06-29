Console.WriteLine("\n ## REPETIÇÃO WHILE ##");

//var i = 0;

//while(i <= 10)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

// Exemplo uma tabuada, normalmente eu faço com for
//int numero;
//int contador = 1;

//Console.WriteLine("\nDigite um número maior que zero: ");
//numero = Convert.ToInt32(Console.ReadLine());

// if(numero > 0)
//{
//    // loop while
//    Console.WriteLine($"Tabuada do {numero}\n");
//    while(contador < 11)
//    {
//        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//        contador++;
//    }
//}
//else
//{
//    Console.WriteLine("Número deve ser maior que zero!");
//}


Console.WriteLine("\n---- USANDO O COMANDO BREAK ----");


//while (true)
//{
//    Console.WriteLine("\n Informe um número inteiro : ( Para sair 999)");

//    int numero = Convert.ToInt32(Console.ReadLine());

//    if(numero == 999)
//    {
//        break;
//    }

//    if( numero % 2 == 0)
//    {
//        Console.WriteLine($"{numero} é PAR");
//    }
//    else
//    {
//        Console.WriteLine($"{numero} é IMPAR");
//    }
//}

Console.WriteLine("\n---- EXEMPLO WHILE ANINHADOS ----");

int x = 0;
//int y = 0;

while(x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x} ,{y}) ");
        Console.Write($"({x} ,{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}




Console.WriteLine("Fim do processamento...");
Console.ReadKey();
