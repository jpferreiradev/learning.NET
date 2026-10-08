using System.Runtime.InteropServices;

Console.WriteLine("### Construtores ### \n ");

Aluno aluno = new Aluno("Maria", 22, "feminino", "S");

// Operador ternario(condição ? expressao1_se_true : experess2_se_false)

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);




Console.ReadKey();

public class Aluno
{

    // Construtor 1
    public Aluno(string nome) => Nome = nome; // Corpo de expressão ou Expression Body
   
        
    

    // Exemplo construtor com parametros| Construtor 2
    public Aluno(string nome,int idade, string sexo, string aprovado) : this(nome) // A palavra this, ele se refere a instância atual da classe Aluno
    {

        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }




    // atributos
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;




}