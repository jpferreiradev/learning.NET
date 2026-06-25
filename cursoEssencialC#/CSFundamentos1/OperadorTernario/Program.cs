Console.WriteLine("### Operador Uniario e Ternario ###\n");

int positivo = 1;
int resultado;
resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("Informe o número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");


// Operador condiocinal ternario

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resposta = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {resposta}");

Console.ReadKey();