Console.WriteLine("Conversão de tipos\n");

// Conversão implicita

int varInt = 100;
double varrDouble = varInt;

Console.WriteLine(varrDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);


Console.WriteLine();
Console.WriteLine("---- CONVERSÃO EXPLICITA ----");

double varDouble = 12.456;
int varrInt = (int) varDouble; // Perda de precisão
Console.WriteLine(varrInt);

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2; // 2.5
Console.WriteLine(resultado);


Console.ReadLine();
