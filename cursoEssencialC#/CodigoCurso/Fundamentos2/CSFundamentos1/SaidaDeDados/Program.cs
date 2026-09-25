Console.WriteLine("Saida de dados : Formatação\n");


int idade = 25;
string nome = "Maria";

Console.Write(idade); 
Console.WriteLine(nome);
Console.WriteLine();
Console.WriteLine("--------------\n");

// Escreve na mesma linha "Maria tem 25 anos"
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");
Console.WriteLine();
Console.WriteLine("-----------------\n");

// Usar a concateção: usando o operador de +

Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();

Console.WriteLine("----CONCATENAÇÃO------------");



// Forma mais atual usa a interpolação de String $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine("------INTERPOLAÇÃO-----------");
Console.WriteLine();
// Não é tando usada -> place holders : Usa {} com numeração com inicio em zero

Console.WriteLine("---- PLACE HOLDERS ----");
Console.WriteLine("{0} tem {1} anos",nome,idade);

Console.ReadLine();

