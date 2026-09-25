Console.WriteLine("### COVERSÃO DE TIPOS 2 ### \n");

//int valorInt = 123;
//double valorDouble = 12.45;
//decimal valorDecimal = 12.45678m;

//string s1 = valorInt.ToString();
//string s2 = valorDouble.ToString();
//string s3 = valorDecimal.ToString();

//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);

int valorInt = 10;
double valorDouble = 5.35;
bool valorBoolean = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBoolean));
Console.WriteLine(Convert.ToInt32(valorDouble));

int varIInt = 10000;
//Console.WriteLine(Convert.ToByte(varIInt)); // Aqui vai ter uma exceção OverflowException

Console.ReadLine();
