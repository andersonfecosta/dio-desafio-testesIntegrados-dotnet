using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuAppConsole
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {         
            int resultado = val1 + val2; 
            historico.Insert(0,"Res:" + resultado);
            return resultado;
        }
         public int Subtrair(int val1, int val2)
        {          
            int resultado = val1 - val2;
            historico.Insert(0,"Res:" + resultado);
            return resultado;
        }
         public int Multiplicar(int val1, int val2)
        {           
            int resultado = val1 * val2;
            historico.Insert(0,"Res:" + resultado);
            return resultado;
        }
         public int Dividir(int val1, int val2)
        {          
            int resultado = val1 / val2;
            historico.Insert(0,"Res:" + resultado);
            return resultado;
        }

        public List<string> Historico()
        {           
            historico.RemoveRange(3, historico.Count -3);
            return historico;
        }
    }
}