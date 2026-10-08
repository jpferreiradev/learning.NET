Console.WriteLine("### Argumentos por refêrencia - OUT ### \n");

Console.Write("Informe o raio do circulo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

//double perimetro = circulo.CalculaPerimetro(raio);
//double area = circulo.CalculaArea(raio);

double circuferencia = circulo.CalculoAreaPerimetro(raio, out double area);

Console.WriteLine("Perímetro da circunferencia: " + circuferencia);
Console.WriteLine("Área da circunferencia: " + area);



Console.ReadKey();

public class Circulo
{
    //public double CalculaArea(double raio)
    //{

    //    double area = Math.PI * Math.Pow(raio, 2);
    //    return area;
    //}

    //public double CalculaPerimetro(double raio)
    //{
    //    double perimetro = 2 * Math.PI * raio;
    //    return perimetro;
    //}

    
    public double CalculoAreaPerimetro(double raio, out double area) //  Método usando [OUT]
    {
        area = Math.PI * Math.Pow(raio, 2); // Aqui que usa o OUT, 
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

}