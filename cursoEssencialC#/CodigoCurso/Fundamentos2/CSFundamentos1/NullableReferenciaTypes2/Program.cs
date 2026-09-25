Console.WriteLine("### Nullable Referencias Types 2 ### \n");

//// Você não consegue executar nada que esteja Null;
//string nomee = null;

//Console.WriteLine(nome);
// Console.WriteLine(nome.ToUpper());

//// Aqui vai dar execeção em tempo de execução

Console.ReadKey();

// Como resolver esse problema: 

string? nome = null;
Console.WriteLine(nome?.ToUpper());

// Outra forma, referencia correta;

string nomee = "";
Console.WriteLine(nomee?.ToUpper());