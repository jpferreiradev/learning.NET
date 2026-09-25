Console.WriteLine("## Operadores relacionais ###\n");

int x = 10;
int y = 20;

bool resultado = x == y;

Console.WriteLine(x == y);
Console.WriteLine(x != y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x <= y);
Console.WriteLine(x >=y);

Console.WriteLine(resultado);



// Com String

Console.WriteLine("------ STRINGS\n");
string a = "curso";
string b = "Curso";
string m = "JP";
string n = "JP";
 
Console.WriteLine(a == b); // false
Console.WriteLine(m == n); // true

// Método equals, comparar 2 strings é identico ao == / =! 

Console.WriteLine(a.Equals(b));

Console.ReadKey();
