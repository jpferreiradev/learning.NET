using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ExemploCastingEConversaoImplicita
    {
    
        public void conversao()
        {
            float x = 4.5f;

            double y = x; // Conversao implicita de double para float

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float) a; //Exemplo de casting entre double para float


            double w;
            int c;

            w = 5.1; //Nesse caso, você teve perda de informação, resultado 5;
            c = (int) a;
            Console.WriteLine(c);

            int o = 5;
            int p = 2;

            double resultado = (double) o / p; //
            Console.WriteLine(resultado);
        }

    }
}
