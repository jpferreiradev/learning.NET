Console.WriteLine("### Passando Argumentos por valor ### \n");

int x = 20;

Console.WriteLine("\n Valor do argumento x antes de passar por valor: " + x);


Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\n Valor do argumento x depois de passar por valor: " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine("\n Valor do parametro y no método dobrar: " + y);
    }
}

