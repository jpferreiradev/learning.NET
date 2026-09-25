Console.WriteLine("### Operadores Incremento e decremtno ###\n ");


//int x = 10;
//// x = x+1;
//x++; // 11
// x-- // 9

// Operador de incremento ++
// pre-incremento ++x / pos-incremnto x++

// Operador de decremento 
// pré-decremento --x / pos-incremento x--;




int x = 0;
Console.WriteLine($"x = {x}");

// pos-incrememnto -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;

Console.WriteLine($"pos-incremento -> {resultado1}");
Console.WriteLine($"valor de x => {x}\n");


// pre-incrememnto -> primeiro incrementa depois resolve
int y = 0;
int resultado2 = ++y + 10;


Console.WriteLine($"pos-incremento -> {resultado2}");
Console.WriteLine($"valor de y => {y}\n");

Console.WriteLine(" -----------------DECREMENTO-------------------\n");

int a = 0;
Console.WriteLine($"x = {a}");

// pos-decremento -> primeiro resolve depois decrementa
int resultadoo = a-- + 10;

Console.WriteLine($"pos-incremento -> {resultadoo}");
Console.WriteLine($"valor de x => {a}\n");


// pos-decremento -> primeiro decrementa depois resolve
int b = 0;
int resultadoo2 = --b + 10;


Console.WriteLine($"pos-incremento -> {resultadoo2}");
Console.WriteLine($"valor de y => {b}\n");








Console.ReadKey();