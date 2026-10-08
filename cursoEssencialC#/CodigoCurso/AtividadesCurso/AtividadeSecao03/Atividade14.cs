public class Atividade14
{
    public static void Executar()
    {

        Console.Write("Informe uma frase: ");
        String frase = Console.ReadLine();

        Console.WriteLine($"A frase maiscula é {frase.ToUpper()}");
        Console.WriteLine($"A frase maiscula é {frase.ToLower()}");
    }


    
}