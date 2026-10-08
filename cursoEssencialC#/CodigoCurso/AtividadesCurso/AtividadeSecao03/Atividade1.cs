public class Atividade1
{
    public static void Executar()
    {
        Console.WriteLine("Executando questão 01");

        int numero1, numero2, numero3;

        Console.Write("Informe o primeiro número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o terceiro número: ");
        numero3 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Os números são: {numero1}, {numero2}, {numero3}");

        if (numero1 > numero2 || numero1 > numero3)
        {
            Console.WriteLine($"Numero {numero1} é maior!");
        }
        else if (numero2 > numero1 || numero2 > numero3)
        {
            Console.WriteLine($"Numero {numero2} é maior");

        }
        else
        {
            Console.WriteLine($"Numero {numero3} é maior");
        }
        
        
        

    }
}