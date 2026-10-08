Console.WriteLine("### Argumentos nomeados ### \n");

Email email = new();

email.Enviar("teste@email.com", "Urgente", "Reunião de orçamento");
Console.WriteLine();

// argumento nomeados
Console.WriteLine("Argumentos nomeados: ");
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião Orçamento"); // Forma 1
email.Enviar(destino: "teste@email.com", assunto: "Reunião orçamento", titulo: "Urgente"); // Forma 2


Console.WriteLine("Teste, está funcionando! ");

Console.ReadKey();

public class Email
{
    public void Enviar( string destino, string titulo,string assunto)
    {
        Console.WriteLine($"\n Para {destino}, - {titulo} \n Assuntos:{assunto}"); 
    }
}