using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class OperadoresDeAtribuicao
    {
        
        public void operadoresAtribuicaoExemplo()
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("OPERADORES DE INCREMENTO E DECREMENTO ");

            int z = 10;
            int y = 10;
            z++;
            y--;
            Console.WriteLine(z);
            Console.WriteLine(y);


        }
    }
}
