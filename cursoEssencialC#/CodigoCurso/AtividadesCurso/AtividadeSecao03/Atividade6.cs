public class Atividade6
{
    public static void Executar()
    {

        Console.WriteLine("Primeira forma: ");
        for (int i = 10; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Incrementando 2 em cada passo");
        for (int i = 10; i < 20; i += 2)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Incrementeando 1 em cada passo");

        for (int i = 10; i < 20; i += 1)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Com loop infinito e break e continue");

        for (int i = 10; i < 20; i += 2)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}