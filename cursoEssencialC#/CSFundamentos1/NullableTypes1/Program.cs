Console.WriteLine("### Nullable Types ###");

/*
int valor = 100; 
Console.WriteLine(valor);

int valor2 = null; // Aqui vai dar erro
Console.WriteLine(valor2);
*/

//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;



// simplificando

int? i = null;
double? d = null;
bool? b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

Console.WriteLine("------------------------------");

int? a = 1;
int z = a ?? 0; // Operador de coalescência
Console.WriteLine(z);


Console.WriteLine("\n---- No caso com expressões---");

int? x = 4;
int? y = 3;
int? c = x * y;
Console.WriteLine(c);

//Propriedades Hasvalue e Value

Console.WriteLine("\n---- Propriedades Hasvalue e Value ------");

int? f = null; // 100
if (f.HasValue)
{
    Console.WriteLine($"b = {f.Value}");
}
else
{
    Console.WriteLine("B não possui um valor NULL  ");
   
}

