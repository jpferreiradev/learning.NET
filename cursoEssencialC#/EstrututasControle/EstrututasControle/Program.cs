using System.Security.Cryptography.X509Certificates;

Console.WriteLine("### ESTRUTURAS DE CONTROLE ###\n");

//Console.WriteLine("Se cliente for especial? (S/N)");
Console.WriteLine("Se o cliente for especial (true/false)");
//var resposta = Console.ReadLine();
var resposta = Convert.ToBoolean(Console.ReadLine());

// Exemplo if 
//if (resposta == "S")
//{
//    Console.WriteLine("Cliente especial !!");
//}
// Exemplo if com bool
if (resposta)
{
    Console.WriteLine("Cliente especial !!");
}
Console.WriteLine("Fim do processamento!");

// Estrutura if com mais de um instrução 

Console.WriteLine("Informe o valor de X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de Y:");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)

    Console.WriteLine(" X é maior que Y");

if(x < y)

    Console.WriteLine("X é menor que Y");

if(x == y)

    Console.WriteLine("X é igual a Y");


// remover as chaves é opcional



Console.ReadKey();