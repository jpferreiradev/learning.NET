using System.Security.Cryptography.X509Certificates;

Console.WriteLine("### Conceito da palavra This ### \n");


//Teste t1 = new Teste();
//t1.Num1 = 10;
//t1.Num2 = 20;
//t1.Exibir();

//Teste t2 = new Teste();
//t2.Num1 = 88;
//t2.Num2 = 99;
//t2.Exibir();

Teste t1 = new Teste(999);


Console.ReadKey();
// A partir daqui que você criar as classe;

//public class Cliente
//{
//    public string? Nome;
//    public int Idade;

//    public Cliente(string? Nome, int Idade)
//    {
//        this.Nome = Nome;
//        this.Idade = Idade;
//    }
//}

// ----  Outra forma de passar o this, passar como um parametro ---

//public class Teste
//{
//    public int Num1;
//    public int Num2;

//    public void PassarParametros(Teste t)
//    {
//        Console.WriteLine($"\nthis = {this}");
//        Console.WriteLine("Num1: " + t.Num1);
//        Console.WriteLine("Num2: " +t.Num2);
//    }

//    public void Exibir()
//    {
//        // passando this como um parametro ( a classe Teste) 
//        PassarParametros(this);
//    }
//}

// -- Invocar outro construtor da mesma classe

public class Teste
{
    // Exemplo de sobrecarga de construtores
    // Exemplo um construtor, dois parametros
    public Teste(int num1,int num2)
    {
        Console.WriteLine($"\n Construtor com dois parametros {num1} e {num2}");
    }

    // Exemplo outro construtor, um parametro, 
    public Teste(int num): this(777, 888) // Essa forma
    {
        Console.WriteLine("\n Construtor com um parametro " + num);
    }
}
