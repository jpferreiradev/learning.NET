using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Atividades
{
    internal class Exercicio01
    {
        
        public void exercicio01()
        {
            Console.WriteLine("Entre com o nome completo: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua sala?");
            int quantidadeQuatos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);




            Console.WriteLine("Quantidade de quartos: " + quantidadeQuatos);
            Console.WriteLine("Seu nome é:" + nome);
            Console.WriteLine("Preço do produto é R$" + precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            
               

            
            

        }
    }
}
