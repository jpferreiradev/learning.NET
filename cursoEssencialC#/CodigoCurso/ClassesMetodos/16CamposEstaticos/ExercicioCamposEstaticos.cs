public class ExercicioCamposEstaticos
{
    public static void Executar()
    {

        ContaCorrente c1 = new ContaCorrente();
        c1.Conta = 101;
        c1.Nome = "Maria";
        //c1.Juros = 3.99f;

        ContaCorrente c2 = new ContaCorrente();
        c2.Conta = 102;
        c2.Nome = "Marta";
        //c2.Juros = 4.99f;

        ContaCorrente.Juros = 4.25f; // Campo estatico

        Console.WriteLine($"Cliente: {c1.Nome} - Juros Anul : {c1.JurosAnual()}");
        Console.WriteLine($"Cliente: {c2.Nome} - Juros Anul : {c2.JurosAnual()}");
    }
   
    public class ContaCorrente
    {
        // Atributos, campos de estancia
        public int Conta;
        public string? Nome;
        public static float Juros;// Aqui ele deixou de ser um membro de estancia, ele passou a ser membro da classe

        // Metodos
        public float JurosAnual()
        {
            return Juros * 12;
        }

    }

}




