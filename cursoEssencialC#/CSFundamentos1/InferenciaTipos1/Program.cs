Console.WriteLine(" ### INFERÊNCIA TIPOS (VAR) ###\n");

var idade = 34;
var nome = "João";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}"); // Interpolação de String

// Limitações

//var salario = null;
//var titulo;
//var salario, imposto, total;



// não posso mudar o tipo apos inicializar
//var num = 10;
//num = num + 20;
//num = "Teste";

// Exemplo de classe com var

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}