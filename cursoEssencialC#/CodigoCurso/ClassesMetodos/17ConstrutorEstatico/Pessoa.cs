public class Pessoa
{
    public static int IdadeMinima;
    public int Idade {  get; set; }
    public string Nome { get; set; } = string.Empty; // Não entendi isso aqui

    public Pessoa(int idade,string nome)
    {
        Console.WriteLine("\n Executando o construtor parametrizado ( com parametros) ");
        Idade = idade;
        Nome = nome;
    }
    
    // Construtor padrão
    public Pessoa()
    {
        
    }

    // Construtor estatico
     
    //static Pessoa()
    //{
    //    Console.WriteLine("\nExecutando o construtor estático ");
    //    Console.WriteLine(" \nInicializando o campo IdadeMinima ");
    //    IdadeMinima = 18;
    //}
  
  
    


}