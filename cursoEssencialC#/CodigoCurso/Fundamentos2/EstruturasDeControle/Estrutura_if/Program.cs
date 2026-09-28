Console.WriteLine("### Estrutura if ###\n");

//Console.WriteLine("Cliente especial (S/N)");
//var resposta = Console.ReadLine();

//if(resposta == "S")
//{
//    Console.WriteLine("Desconto de 10%");
//}

// Segunda forma


//Console.WriteLine("Cliente especial (S/N)");
//var resposta = Convert.ToBoolean(Console.ReadLine());

//if (resposta)
//{
//    Console.WriteLine("Desconto de 10%");
//}

// Terceira forma

Console.Write("Informe o valor de X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("X é maior Y");
}
if(x < y)
{
    Console.WriteLine("Y é maior X");
}
if(x == y)
{
    Console.WriteLine("X é igual a Y");
}



Console.WriteLine("Fim do processamento...");
Console.ReadKey();
