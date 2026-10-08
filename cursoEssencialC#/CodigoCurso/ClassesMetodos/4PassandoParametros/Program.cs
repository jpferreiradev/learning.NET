Console.WriteLine("### Passando pametros");


Aluno aluno = new();
aluno.Consultar();


Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;


    public void Consultar()
    {
        var aluno = new Aluno();

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sexo: ");
        aluno.Sexo = Console.ReadLine();
        Console.Write("Aprovado: (S)im e (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();

        curso.Resultado(aluno); // Ficou mais enxuto o código; Passando um objeto como parametro
        // Invocou um método dentro de outro método;
    }
}


public class Curso
{
    // Forma nova
    public void Resultado(Aluno aluno) // Aqui é para mostrar a relação dos parametros do metodo com os atributos da classe // Ele já usa o objeto direto
    {
        Console.WriteLine($"\n O aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos ");
        if (aluno.Aprovado == "S")
        {
            Console.WriteLine("\n foi Aprovado!");
        }
        else
        {
            Console.WriteLine("\n Foi reprovado!");
        }


    }


}


// Forma antiga:

//public void Resultado(string nome, int idade, string sexo, string aprovado) // Aqui é para mostrar a relação dos parametros do metodo com os atributos da classe
//{
//    Console.WriteLine($"\n O aluno {nome}, sexo {sexo} com {idade} anos ");
//    if (aprovado == "S")
//    {
//        Console.WriteLine("\n foi Aprovado!");
//    }
//    else
//    {
//        Console.WriteLine("\n Foi reprovado!");
//    }


//}