Console.WriteLine("### Operadores de atribuição ### \n");


// usando operadores de atribuição com tipos numericos


var x = 10;

x = 20;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x+=5 == > {x+= 5}");
Console.WriteLine($"x-=3 == > {x-= 3}");
Console.WriteLine($"x*=4 == > {x*= 4}");
Console.WriteLine($"x/=5 == > {x/= 5}");
Console.WriteLine($"x%=5 == > {x%= 5}");

// Operador + e += com Strings, String é um tipo de referencia

//var y = "123";
string y ="123";

Console.WriteLine($"O valor inicial de {y} ");

y += "456";

//Console.WriteLine($"y+= \"456\" -> {y+="456"} "); // Sequencia de escapes
Console.WriteLine($"y+= \"456\" -> {y} "); 





Console.ReadKey();
