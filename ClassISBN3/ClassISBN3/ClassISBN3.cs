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
            else if(numeros.Length == 13)
            {
                for(int i = 0; i < numeros.Length; i++)
                {
                    if(numeros[i] % 2 == 0)
                    {
                        multiplicacion = numeros[i] * 3;
                    }
                    else
                    {
                        multiplicacion = numeros[i] * 1;
                    }
                    sumatoria += multiplicacion;
                }

                if(sumatoria % 10 == 0)
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
