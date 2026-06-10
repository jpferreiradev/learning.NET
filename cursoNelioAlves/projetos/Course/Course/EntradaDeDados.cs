using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class EntradaDeDados
    {
    
    public void entradaDados()
        {
            
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            



            Console.WriteLine("Você digitou:" + frase);
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
            Console.WriteLine("------- SPLIT -------");

            string s = Console.ReadLine();

            //Vetor
            //string[] vet = s.Split(' ');
            string[] vet = Console.ReadLine().Split(' '); //forma mais direta!

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(s);




        }
    
    }
}
