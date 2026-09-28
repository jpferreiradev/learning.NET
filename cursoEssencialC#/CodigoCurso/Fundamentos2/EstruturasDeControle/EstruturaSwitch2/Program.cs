Console.WriteLine("## Estrutura Switch 2 ###\n");

// Exemplo 1

//Console.Write("Informe o mês: ");
//var mes = Console.ReadLine().ToLower(); // Converte para caixa baixa;

//switch (mes)
//{
//    case "janeiro":
//        case"março":
//        case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;
//    case "fevereiro":
//        Console.WriteLine("Este mês tem 28 ou 29 dias");
//        break;
//    default: Console.WriteLine("Este mês tem 30 dias");
//        break;

//}


// Exemplo 2 - Switch com instroções aninhadas

int cargo = 0;
int funcao = 0;
Console.WriteLine("Você é Gerente(1) ou Programador(2)? \t");
cargo = Convert.ToInt32(Console.ReadLine());

if(cargo == 2)
{
    Console.WriteLine("Você é júnior (1) ou Senior(2)? \t");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1: Console.WriteLine("\nBem-vindo Gerente!");
        break;
    case 2: Console.WriteLine("\nBem-vindo programador!");
        
        switch(funcao)
        {
            case 1: Console.WriteLine("\n Você é Jr!");
                break;
            case 2: Console.WriteLine("\n Você é senior!");
                break;
                default : Console.WriteLine("\n Função desconhecida.");
                break;
        }
        break;
    default:
        Console.WriteLine("\n Não consigo te identificar!");
        break;
}


Console.WriteLine("Fim do processamento...");
Console.ReadKey();