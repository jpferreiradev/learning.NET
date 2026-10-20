using _20Enum; // Achei legal isso

Console.WriteLine("### Enum ### \n");


// Exemplo de como criar um ENUM
Console.WriteLine(DiasDaSemana.Domingo); // Nome do membro
Console.WriteLine(DiasDaSemana.Terça);

// Exemplo de como mostrar o valor

//int dia1 =(int) DiasDaSemana.Domingo; // O valor do membro, fazendo Casting
//int dia2 =(int) DiasDaSemana.Terça;

//Console.WriteLine($"\n{DiasDaSemana.Domingo} vale : {dia1}");
//Console.WriteLine($"\n{DiasDaSemana.Terça} vale : {dia2}");

// Atribuindo o enum e colocando o seu respectivo valor do lado
Console.WriteLine();

Console.WriteLine($"{DiasDaSemana.Domingo} - {(int) DiasDaSemana.Domingo}");
Console.WriteLine($"{Categorias.Moda} - {(int) Categorias.Moda}"); // Conversão e obter o valor
Console.WriteLine($"{Categorias.Automotivo} - {(int) Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int) Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int) Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int) Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int) Categorias.Brinquedos}");

Console.WriteLine("\n Selecione a categoria teclando o seu valor: ");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor; // Fazendo ima conversão forçada para o valor / Para obter o nome, faz um casting 
Console.WriteLine($"\n Você selecionou a categoria : {nomeMembroEnum.ToString()}");

Console.ReadKey();

//enum DiasDaSemana{

//    Segunda, //0 
//    Terça, //1
//    Quarta, //2
//    Quinta, //3
//    Sexta, //4
//    Sabado,//5
//    Domingo //6
//}


// Atribundo valor a um dos membros, 
//enum DiasDaSemana
//{

//    Segunda, //0 
//    Terça, //1
//    Quarta = 5, //5
//    Quinta, //6
//    Sexta, //7
//    Sabado,//8
//    Domingo //9
//}

// Atribuindo valores aos membros


