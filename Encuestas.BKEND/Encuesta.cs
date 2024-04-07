using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas.BKEND
{
    public class Encuesta
    {
       int Contador = 0;
        public int NumeroEncuesta { get; set; }
        public int Ambiente { get; set; }
        public int Jefes { get; set; }
        public int Salario { get; set; }


        public Encuesta()
        {
            NumeroEncuesta = ++Contador;
        }

        public void Agregar(int aAmbiente, int aJefes, int aSalario)
        {
            Ambiente = aAmbiente;
            Jefes = aJefes; 
            Salario = aSalario;
        }

    }
}
