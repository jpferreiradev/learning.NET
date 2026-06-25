Console.WriteLine("\n### Tipos de referência Anuláveis");

// string nome = null / Erro 
string? nome = null; // Corrigindo o erro;
// string nome = ""; -> Outra maneira
Console.WriteLine(nome?.ToUpper());

Console.ReadKey();
