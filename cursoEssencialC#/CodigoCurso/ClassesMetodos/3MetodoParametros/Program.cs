Console.WriteLine("### Métodos com parâmetros \n ");



MinhaClasse minhaClase = new MinhaClasse();

// valores dos argumentos
minhaClase.Saudacao("Maria",DateTime.Now.ToShortDateString());


Console.ReadKey();

public class MinhaClasse
{
    // os parametos do método
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}