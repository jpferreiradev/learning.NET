using System.ComponentModel;
using System.Runtime.InteropServices;

Console.WriteLine("### Instrução for ### \n");


// for(inicialização; condição; iteração)

for (int i = 0; i < 11; i++)
{
    Console.Write(" " + i);
}


Console.WriteLine();
Console.WriteLine();
Console.Write("Informe um número inteiro:  ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabuada de:{numero}");

//int resultado = 0; Forma que eu fiz
// forma do professor -> int resultado;

// Forma que eu fiz
for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine();
// Forma do professor;
int resultado;
//inicialização / condição/ interezação
for (int i = 0; i < 11; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.ReadLine();
