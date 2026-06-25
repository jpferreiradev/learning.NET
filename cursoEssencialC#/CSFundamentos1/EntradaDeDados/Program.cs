Console.WriteLine("\n### Entrada de dos ###");

Console.WriteLine("\nInforme o seu nome: ");

string nome = Console.ReadLine();

Console.WriteLine("\nO seu nome é:" + nome); // Concatenação

Console.WriteLine($"\nO seu nome é {nome}"); // Interpolação


// Aqui é se fosse um outro tipo, exemplo int double

Console.WriteLine("Informe a sua idade: ");

int idade = Convert.ToInt32(Console.ReadLine()); // Aqui você vai precisar converter o tipo

Console.WriteLine($"A minha idade é: {idade}"); // Interpolação 



Console.ReadKey(); //Segurar a tela, esperando o usuario