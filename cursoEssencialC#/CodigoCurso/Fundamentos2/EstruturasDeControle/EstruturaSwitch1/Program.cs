Console.WriteLine("### Estruta switch ###\n");

Console.WriteLine("Valor da compra R$ 600,00\n");
Console.Write("Informe o número de parcelas ( 1 a 3): ");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\n Prestação R${600/numeroParcelas}");
        break;
    case 2: 
        Console.WriteLine($"Prestação R${600 / numeroParcelas}");
        break;
    case 3: Console.WriteLine($"Prestação R$ {600 / numeroParcelas}");
        break;
    default:
        Console.WriteLine("Valor inválido, informe de 1 a 3");
        break; 

}

// numeroParcelas (1 / 600) -> (2/ 300) -> (3/200)

// Outro exemplo

Console.Write("Informe um número inteiro: ");
var n = Convert.ToInt32(Console.ReadLine());

switch(n % 2)
{
    // Se o resultado for 0
    case 0:
        Console.WriteLine($"{n} é um número par!");
        break;
    case 1: Console.WriteLine($"{n} é um número impar");
        break;
    
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
