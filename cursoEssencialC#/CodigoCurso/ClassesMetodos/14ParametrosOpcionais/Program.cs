Console.WriteLine("### Parametros opcionais ### \n");



Console.WriteLine("Informe o destino:  ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo:  ");
var titulo = Console.ReadLine();

var assunto = Console.ReadLine();


Email email = new();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino,titulo);
email.Enviar(destino,titulo,assunto);

// O que eu não posso fazer:
//email.Enviar(destino, , assunto); // causa um erro
email.Enviar(destino,assunto:assunto); // Só pode saltar usando os argumentos nomeados;


Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino padrão", string titulo = "Título padrão", string assunto = "Assunto padrão") // Exemplo de parametro opcional, 1 parametro obrigatorio e 2 parametros opcionais
    {
        Console.WriteLine($"\n Para {destino}, - {titulo} \n Assuntos:{assunto}");
    }
}