Console.WriteLine("### Operadores uniario e ternario ### \n");


// Operador uniario + 

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine("Operador uniario + " + positivo);


// Operador uniario - 

Console.Write("Informe o número: ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Operador uniario - : O negativo de {n} é igual a {-n}");


// Operador condicional ternário (?:) condição ?express1_se_true : express_se_false

Console.Write("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resultadoo = temp > 27 ? "Quente" : "Normal"; // Exemplo de como é feito;

Console.WriteLine($"O tempo está {resultadoo}");


//  Outro exemplo de operador ternario 

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string opcao = x > y ? "x é maior que y" :
               x < y ? "x é menor que y":
               x == y ? "x é igual a y " : "Sem resultado";

Console.WriteLine(opcao);

Console.ReadKey();