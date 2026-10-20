using System.Globalization;

Console.WriteLine("### Bloco Try Catch ### \n");
Console.WriteLine("Divisão ded números inteiros");
Console.WriteLine(" x / y");



Console.Write("\n Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("\n Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());


// Exemplo de como se usa o bloco try/catch/ finally
//try
//{
//    int z = x / y;
//    Console.WriteLine($"\n {x} / {y} = {z}");
//}
//catch
//{

//    Console.WriteLine("\n Não existe divisão por zero, tente outro número...");	
//}
//finally
//{
//    Console.WriteLine("\n Processamento concluido...");
//}

try
{
    int z = x / y;
    Console.WriteLine($"\n {x} / {y} = {z}");
}
catch (Exception ex) // Referencia a um objeto Exception
{
    Console.WriteLine("\n Não existe divisão por zero, tente outro número...");
    Console.WriteLine($" \n Erro: <<< {ex.Message} >>>"); // Aqui mostra o erro que ocorreu
    Console.WriteLine($"\n Detalhes {ex?.StackTrace?.ToString()}"); // Aqui ele colocou o operador condicional nulo ?.
   
}
finally
{
    Console.WriteLine("\n Processamento concluido...");
}

Console.ReadKey();

//DivideByZeroException