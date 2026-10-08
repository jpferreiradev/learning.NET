public class Atividade13
{
    public static void Executar()
    {
        // Exemplo de como remover caracteres

        Console.WriteLine("Nome da string = w3resource");
        Console.WriteLine("Remover String = " + remove_Caractere("w3resource", 1));
    }
    public static string remove_Caractere(string str, int n)
    {
        return str.Remove(n, 1);
    }

}




