using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class TiposDeVariaveis
    {

        
        public void tiposDeVariaveis()
        {
            //Tipos pré definidos e tipo .net das variáveis;


            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 255; // tipo c#
            sbyte n2 = 127; // tipo .NET
            int n3 = 1000;
            int n4 = 2147483647;
            long n5 = 2147483648L;
            float n6 = 4.5f;
            double n7 = 4.5;
            string nome = "Maria Grenn";
            string nome2 = "João Paulo";
            object ob1 = "Alex Brow";
            object ob2 = "4.5f";



            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(nome);
            Console.WriteLine(nome2);
            Console.WriteLine(ob1);
            Console.WriteLine(ob2);

            Console.WriteLine("---------------------------------- VALORES MAXIMOS E MINIMOS -----------------------");

            int N1 = int.MinValue;
            int N2 = int.MaxValue;
            sbyte N3 = sbyte.MinValue;
            decimal N4 = decimal.MaxValue;

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);
        }
        

    }
}
