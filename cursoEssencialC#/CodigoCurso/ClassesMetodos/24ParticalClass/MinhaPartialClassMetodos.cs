using System;
using System.Collections.Generic;
using System.Text;

namespace _24ParticalClass
{
    public partial class MinhaPartialClass
    {
        
        public TimeSpan CalculoIdade(DateTime DataNascimento)
        {
            return (DateTime.Now.Date - DataNascimento);
        }

        public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
        {
            var diferenca = data1.Subtract(data2);
            return diferenca;
        }
   
    }
}
