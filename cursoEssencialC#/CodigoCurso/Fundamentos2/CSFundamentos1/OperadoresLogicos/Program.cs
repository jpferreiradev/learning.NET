Console.WriteLine("### Operadores lógicos ### \n");

bool c1 = 5 >= 7; // true;
bool c2 = 9 != 8; // false;

bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");

// Operador and -> && 

resultado = c1 && c2;
Console.WriteLine("Operador AND -> && é:" + resultado);

// Operador OR -> ||

resultado = c1 || c2;
Console.WriteLine("Operador OR -> || é:" + resultado);

// Operador NOT -> ! (Negando tudo) 
resultado = !c1;
Console.WriteLine("Operador Not-> ! é:" + resultado);

Console.ReadKey();
