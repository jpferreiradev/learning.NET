Console.WriteLine("### Passando argumentos por referencia ### \n");


int x = 20;

Console.WriteLine("\n Valor do argumento x antes de passar por valor: " + x);


Calculo calc = new();
calc.Dobrar(ref x); // Passando a referencia do objeto

Console.WriteLine("\n Valor do argumento x depois de passar por valor: " + x);


int v = 7;
Console.WriteLine(v--);

public class Calculo
{
    public void Dobrar(ref int y) // Passando a referencia do objeto
    {
        y *= 2;
        Console.WriteLine("\n Valor do parametro y no método dobrar: " + y);
    }
}


