// Top level statements
Console.WriteLine("### Métodos\n");


MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();



Console.ReadKey();
// Defições de tipo, precisa vim depois das instruções



class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-vindo");
        ExibirDataAtual();
        
        
    }
    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString()); // Aqui mostra a data abreviada
    }

   
     //public void ExibirDataAtual() =>     //Outra forma de usar o método
     //   Console.WriteLine(DateTime.Now.ToShortDateString()); // Aqui mostra a data abreviada
    
}







// ---> Sintaxe por de baixo dos panos, 
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine(" Digite aqui");
//    }
//}