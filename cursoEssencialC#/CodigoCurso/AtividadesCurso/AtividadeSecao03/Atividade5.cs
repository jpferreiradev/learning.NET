public class Atividade5
{
    public static void Executar()
    {
        Console.WriteLine("Qual a instrução para sair do loop?");
        string opcao = Console.ReadLine();

        
        while(opcao != "x")
        {
            
            if(opcao == "")
            Console.WriteLine("a: quit");
            Console.WriteLine("b: continue");
            Console.WriteLine("c: break");
            Console.WriteLine("d: exit");

            Console.WriteLine("Qual a opção correta? ( tecle x para sair) ");

        }
       
        
        
        
    }
}