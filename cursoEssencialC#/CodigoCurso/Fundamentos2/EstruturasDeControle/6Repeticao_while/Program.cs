Console.WriteLine("### Estrutura while ### \n");


//int i = 1;

//// Incremento
//while(i <= 10)
//{
//    Console.WriteLine($" i = {i}");
//    i++;
//}


//// Decremento
//Console.WriteLine();
//var j = 10;

//while(j > 0)
//{
//    Console.WriteLine($"j = {j}");
//    j--;
//}

//// Tabuada

//Console.Write("Informe um número: ");
//var numero= Convert.ToInt32(Console.ReadLine());

//int contador = 1;

//if(numero > 0)
//{
//    Console.WriteLine($" Tabuada de {numero}");
//    while (contador < 11)
//    {

//        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//        contador++;

//    }
//} else
//{
//    Console.WriteLine("Número deve ser maior que zero");
//}


// Usando o break 

//while (true) // loop infinito, instrução while 
//{
//    Console.Write("Informe um número inteiro: (Para sair tecle 999): ");
//    var numeroo = Convert.ToInt32(Console.ReadLine());

//    if(numeroo == 999) // definição de saida
//    {
//        break; // função break
//    }
//    if(numeroo % 2 == 0)
//    {
//        Console.WriteLine($"{numeroo} é par!"); 
//    }
//    else
//    {
//        Console.WriteLine($"{numeroo} é impar!");
//    }

//}


// Exemplo while aninhadas

int x = 0;

while(x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine(); // Só pra passar para uma outra linha
}



Console.WriteLine("Fim do procesamento");
Console.ReadKey();
