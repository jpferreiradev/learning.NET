using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Atividades
{
    internal class Exercicio
    {
    
        public void atividade01()
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cuso preço é $ 2100,00", produto1);
            Console.WriteLine("{0}, cujo preço é $ 650,50", produto2);

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e genêro {2}", idade,codigo,genero);
            Console.WriteLine();

            double preco1 = 2100.0;
            double preco2 = 650.60;
            double medida = 53.234567;

            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casa decimais: {0:F3}",medida);
            Console.WriteLine("Separador decimal invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));
          

        }
    }
}
