using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassISBN3
{
    public static class ClassISBN3
    {  
        public static bool verificarISBN(int[] numeros)
        {
            int multiplicacion = 0;
            int sumatoria = 0;

            if(numeros.Length == 10)
            {
                int posicion = 10;

                for(int i = 0; i < numeros.Length; i++)
                {
                    multiplicacion = numeros[i] * posicion;
                    sumatoria += multiplicacion;
                    multiplicacion = 0;
                    posicion--;
                }

                if(sumatoria % 11 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
