Console.WriteLine("## Propriedades Get e Set ### \n");


Produto p1 = new Produto();
p1.Nome = "Caderno espiral";
p1.Preco = 4.99;
p1.EstoqueMinimo = 10;



p1.Exibir();


Console.ReadKey();

public class Produto
{
    // atalho prop / Metodos acessores/ Leitura e gravação
    // Propriedades -> Get/Set -> Propriedades automaticas
    // public string? Nome { get; set; } // Propriedade de referencia anulavel string?

    private string nome; // campo de apoio
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }
    // Propriedade de referencia anulavel string?



    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }

    private double desconto = 0.05;
    public double Desconto
    {

        get { return desconto; } // Propriedade somente leitura

    }

    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }

    }
    // Aqui vai ser somente gravação
    private int minimo; // campo de apoio
    public int EstoqueMinimo
    {
        set { minimo = value; } 
    }

    // Campos
    //public string? Nome 
    //public double Preco     
    //public double Desconto 
    //public double PrecoFinal 
    //public int EstoqueMinimo 
    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n {Desconto} \n{PrecoFinal.ToString("c")} \n{minimo}");
    }




}