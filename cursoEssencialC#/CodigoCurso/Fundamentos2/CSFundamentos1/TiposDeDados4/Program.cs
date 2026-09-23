Console.WriteLine("Definindo variáveis do tipo String, object e dynamic");
Console.WriteLine();


string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);
Console.WriteLine();
string valor = "Isto é uma string";

valor = "Isto é uma string alterada";
valor = "teste";

// Se você trabalhar com textos e for realizar muitas alterações, use o StringBuilder

// String Builder;

object nota = 10;
object valor1 = 8.55m;
object nome1 = "JP";
object ativo = true;
object letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativo);
Console.WriteLine(letra);


Console.WriteLine();

// Ele é util quando vamos usar recursos avançados como Reflection, é usado para retornar metadados de tipos em tempo de execução
dynamic nota2 = 10;
dynamic valor2 = 8.55m;
dynamic nome2 = "JP";
dynamic ativo1 = true;
dynamic letra1= 'A';

Console.WriteLine(nota2);
Console.WriteLine(valor2);
Console.WriteLine(nome2);
Console.WriteLine(ativo1);
Console.WriteLine(letra1);



Console.ReadLine();