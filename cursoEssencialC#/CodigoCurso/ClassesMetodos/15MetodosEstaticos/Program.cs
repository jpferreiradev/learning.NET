Console.WriteLine("### Métodos estáticos ###\n");



//Calculadora cal = new();

// O método estatico ele pode ser acessado diretamente atraves do nome da classe;

var soma = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}


//Console.WriteLine("Ela disse \"Sim!\"");



