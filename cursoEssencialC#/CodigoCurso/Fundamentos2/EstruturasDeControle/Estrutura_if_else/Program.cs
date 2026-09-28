Console.WriteLine("### Estrutura if/else ###\n");

//Console.Write("Informe a nota do aluno: ");
//double nota = Convert.ToDouble(Console.ReadLine());

//if(nota > 5)
//{
//    Console.WriteLine("Aluno aprovado!");
//}
//else
//{
//    Console.WriteLine("Aluno reprovado!");
//}


// Outra forma


Console.Write("Informe o valor de X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior Y");
}
else 
{
    if(x < y)
    {
        Console.WriteLine("X é menor que Y");
    }
    else
    {
        Console.WriteLine("X é igual a Y");
    }
}



Console.WriteLine("Fim do processamento....");
Console.ReadKey();
