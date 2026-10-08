Console.WriteLine(" ### Exemplo com métodos com retorno ");


Calculadora calc = new Calculadora();

var valor = calc.Somar(10, 10); // Os argumentos
Console.WriteLine(valor);
Console.WriteLine(calc.Somar(10, 10));



Console.ReadKey();

public class Calculadora()
{
    
    // Métodos com returno
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
