using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class ExemploPlaceholdersConcatenacaoInterpolacao
    {
    
        public void exemplo()
        {

            int idade = 34;
            double saldo = 10.35784;
            string nome = "JP";

            // Aqui é um exemplo de placeholder
            Console.WriteLine("Exemplo de placeholder");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F} reais",nome,idade,saldo);

            // Interpolação, saiu na versão 6 do C#
            Console.WriteLine("Usando Interpolação");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Técnica mais antiga, que é a concatenação de Strings
            Console.WriteLine("Usando a concatenação");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2",CultureInfo.InvariantCulture)  + " reais");

        }
    }
}
