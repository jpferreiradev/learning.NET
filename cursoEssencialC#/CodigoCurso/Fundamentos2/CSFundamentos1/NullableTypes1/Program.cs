Console.WriteLine("Nullable Types - \n");

// Sintaxe padrão 

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool>  b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);


// Simplificar 

int? z = null;
double? x = null;
float? c = null;
bool? B = null;

Console.WriteLine(z);
Console.WriteLine(x);
Console.WriteLine(c);
Console.WriteLine(B);

int? a = 1;
int j = a ?? 0; // Operador de coalescencia 
Console.WriteLine(j);
Console.WriteLine();
// Outro exemplo com expressões

int? k = 4;
int? ç = 3;
int? w = k * ç;

Console.WriteLine(w);
Console.WriteLine();
// Propiedades HasValeu e value 

int? l = null;

if (l.HasValue)
{
    Console.WriteLine($"b = {l.Value} " );
}
else
{
    Console.WriteLine("B não possui valor (null) ");
}


Console.ReadKey();