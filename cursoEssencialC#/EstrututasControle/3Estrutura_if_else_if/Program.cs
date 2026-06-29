Console.WriteLine("## Estrutura elseif ### \n");

Console.WriteLine("\n Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if(nota < 5)
{
    Console.WriteLine("Aluno reprovado!");
} 
else if(nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação");
}
else if(nota >=6  && nota <= 9)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Bem aprovado!");
}

// Pode ser feito de forma melhor, mas aqui é só um exemplo