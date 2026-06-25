Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

// Escrever na mesma linha "Maria tem 25" anos;
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine();
Console.WriteLine(" --------------------------");

// Usar a concatenação : usando o operador + 
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();
Console.WriteLine(" --------------------------");


// usar a interpolação de strings : $ -> a interpolação {}
Console.WriteLine(" ------interpolção----------------");
Console.WriteLine($"{nome} tem {idade} anos");

// 3 forma usada, usar place holders, usa {} com numeração com inicio em zero
Console.WriteLine(" ----place holders----------------");
Console.WriteLine("{0} tem {1} anos", nome, idade);






Console.ReadLine();
