public class Atividade4
{
    public static void Executar()
    {
        while (true)
        {
            int numero;
            int contador = 1;
            Console.Write("\nDigite um número maior que zero ('999' sai ) : \t");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 999)
                break;
            if (numero > 0)
            {
                Console.WriteLine($"\n### Tabuado do {numero} ###\n");
                while (contador < 11)
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("\nNúmero deve ser maior que zero !! ");
            }
        }

    }
}








