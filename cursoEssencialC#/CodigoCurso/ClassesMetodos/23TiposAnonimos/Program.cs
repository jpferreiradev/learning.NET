using System.Net.Http.Headers;

Console.WriteLine("### Tipos anonimos ");

// Tipo anonimo exemplo com 2 propriedades
var aluno = new
{
    Nome = "Maria",
    Idade = 42
};

//aluno.Idade = 34; -> A propriedade do tipo anonimo é somente leitura

Console.WriteLine(aluno.GetType().ToString()); // Aqui é para pegar o nome que o compilador deu e o tipo

Console.WriteLine(aluno.Nome + " " + aluno.Idade);

// Exemplo de um tipo anonimo com outro tipo anonimo

var pessoa = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "jairo@email.com",
    Endereco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"} // Aqui tem um outro tipo anonimo
};

Console.WriteLine(pessoa.Nome);
Console.WriteLine(pessoa.Endereco.Cidade);
Console.WriteLine();

// Array de tipos anonimos

var alunos = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com"},
    new { Id = 2, Nome = "Sonia", Email = "sonia@email.com"},
    new { Id = 3, Nome = "Bruno", Email = "bruno@email.com"}
};

Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);



Console.ReadKey();