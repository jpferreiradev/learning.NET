Console.WriteLine("### Exemplo métodos com retorno ###");


Cadastro cadastro = new();
var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

// alterar a renda

cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterada", cliente);


Console.ReadKey();

// Aqui cria a classe cliente


public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
    public Cliente()
    {

    }

}
public class Cadastro
{
    

    // Exemplo sobrecarga
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Maria", 23, 3000);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }
       

    // Sobrecarga de métodos
    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
        
    }
    public void ExibirDados(string texto,Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.Write($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");

    }
}