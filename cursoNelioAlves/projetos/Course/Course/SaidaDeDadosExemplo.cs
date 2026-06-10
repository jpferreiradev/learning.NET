using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class SaidaDeDadosExemplo
    {
    
        public void saidaDeDados()
        {

            char genero = 'F';
            int idade = 34;
            double saldo = 10.35784;
            string nome = "JP";


            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine("-----------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // Aqui limita o número de casas decimais, exemplo de 2 ;
            Console.WriteLine(saldo.ToString("F4")); // 4 casa decimais
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); // Imprimir com o ponto e não com a virgula, ele vai desconsiderar qualquer formatação de outro pais;
        }

    }
}
