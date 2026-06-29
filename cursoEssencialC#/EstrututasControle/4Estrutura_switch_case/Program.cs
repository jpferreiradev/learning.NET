Console.WriteLine("\n### Estrutura switch case ###");

//int compra = 600;
//Console.WriteLine($"O valor da compra R${compra} ");

//Console.WriteLine("Informe o número de parcelas de ( 1 a 3)");
//var numeroParcela = Convert.ToInt32(Console.ReadLine());

//switch (numeroParcela)
//{
//    case 1:
//        Console.WriteLine($"Prestação R$ {compra / numeroParcela}");
//        break;
//    case 2:
//        Console.WriteLine($"Prestação R$ {compra / numeroParcela}");
//        break;
//    case 3:
//        Console.WriteLine($"Prestação R$ {compra / numeroParcela}");
//        break;
//    default:
//        Console.WriteLine("Valor inválido, informe de 1 a 3....");
//        break;
//} 

//Console.WriteLine("Exemplo do switch para valores diferentes:");


//Console.WriteLine("Informe o nome do mês:");
//var mes =  Console.ReadLine().ToLower();

//switch (mes)
//{
//    case "janeiro":
//    case "Março":
//    case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;
//            case "fevereiro":
//        Console.WriteLine("Este mês tem 28 a 29 dias");
//        break;
//    default:
//        Console.WriteLine("Este mês tem 30 dias!");
//        break;
//}

Console.WriteLine("EXEMPLO SWITCH ANINHA COM OUTRO SWITCH");

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é gerente (1) ou programador (2)");
cargo = Convert.ToInt32(Console.ReadLine());

if(cargo == 2)
{
    Console.WriteLine("Você é junior (1) ou Senior (2)");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch(cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo gerente");
        break;
    case 2:
        Console.WriteLine("\nBem vindo programador");
        // outro switch
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é junior!");
                break;
            case 2:
                Console.WriteLine("\nVocê é senior!");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar....");
        break;

}





Console.WriteLine("Fim do procesamento....");
Console.ReadKey();
