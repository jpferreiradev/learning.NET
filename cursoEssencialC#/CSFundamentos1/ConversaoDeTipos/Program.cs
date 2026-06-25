Console.WriteLine("## Conversão de tipos ##\n");

Console.WriteLine(" ------ CONVERSÃO IMPLICITA");
int idade = 10;
double peso = 40.5;

idade = (int) peso;

int varIInt = 100; // int usa 4bytes
double varDoublee = varIInt; // double usa 8bits

//Preste atenção no tamanho de cada tipo em relação aa isso

Console.WriteLine(varDoublee);

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

Console.WriteLine(" ------ CONVERSÃO EXPLICITA ---\n");

double varDouble = 12.456;
int varInt = (int) varDouble; // Aqui é um CASTING, aqui você vai ter a perda de precisão

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2;

Console.WriteLine(resultado);

Console.WriteLine("------------ toString --------\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);


Console.WriteLine("------------ CLASSE CONVERT --------\n");

int valorrInt = 10;
double valorDoubler = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorrInt));
Console.WriteLine(Convert.ToDouble(valorrInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDoubler));


int varI = 10000;
Console.WriteLine(Convert.ToByte(varI));


Console.ReadLine();