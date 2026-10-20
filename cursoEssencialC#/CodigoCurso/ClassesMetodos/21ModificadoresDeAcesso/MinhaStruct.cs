using System;
using System.Collections.Generic;
using System.Text;

namespace _21ModificadoresDeAcesso
{
    internal struct MinhaStruct
    {
        int MeuCampo; // campo 

        string? MinhaPropriedade { get; set; } // Propriedade

        void MeuMetodo() // Método
        {
            Console.WriteLine("Meu método");
        }

    }
}
