Console.WriteLine("### ENTRADA DE DADOS ###\n");


Console.WriteLine("\nInforme o seu nome:");

String nome = Console.ReadLine(); // Não precisa converter string

Console.WriteLine("\nO seu nome é " + nome);
Console.WriteLine($"\nO seu nome é {nome}");


Console.WriteLine("Informe a sua idade: ");

int idade = Convert.ToInt32(Console.ReadLine()); // Você precisa fazer a conversão para int

Console.WriteLine($"\n Sua idade é {idade} anos");

int idade2 = Console.Read();

Console.WriteLine(idade2); // vai pela tabela ASCII 





Console.ReadKey(); // Segurar a tela e só lê um caractere