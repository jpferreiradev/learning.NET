Console.WriteLine("### Estrutura de repetição Goto e Label");


int i = 1;

repetir: // label (ele é um identificar) pode ser qualquer nome;

Console.WriteLine($"i = {i}");
i++;

if(i <= 10)
{
    goto repetir;
}
Console.WriteLine("fim do processamento...");

Console.ReadKey();

// Aqui é um exemplo de Laço ( looP) 
// Ele é não é muito usado, mas é bom saber

Console.WriteLine(); 
