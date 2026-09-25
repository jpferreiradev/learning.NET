Console.WriteLine("#### Inferencia de tipos (VAR) ### \n");


// abordagem tradicional, definir explicitamente as variaveis

int idade = 25;
string nome = "Maria";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos  e ganha {salario.ToString("c")}"); // toString formatar para moeda local 



// explicitamente as variavis

var iidade = 25;
var nomee = "JP";
var salarioAtual = 2500.00m;


Console.WriteLine($"{nomee} tem {iidade} anos  e ganha {salarioAtual.ToString("c")}"); // toString formatar para moeda local 


// limitações do var

//var salario = null;
//var titulo;
//var salario, imposto, total;


// não posso mudar o tipo
var num = 10;
num = num + 20;
//num = "Teste";

// Uma classe 
var Teste = new Teste();
Teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Exemplo de uma classe, usando o método! ");
    }
}