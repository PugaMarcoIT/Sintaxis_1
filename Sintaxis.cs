using System;

namespace Sintaxis_1
{
    public class Sintaxis : Lexico
    {
        public Sintaxis()
        {
            NextToken();
        }

        public void match(String espera)
        {
            if (espera == getContenido())
            {
                NextToken();
            }
            else
            {
                Console.WriteLine("Error de sintaxis, se espera un " +espera);
                Log.WriteLine("Error de sintaxis, se espera un " +espera);
            }
        }

        public void match(Tipos espera)
        {
            if (espera == getClasificacion())
            {
                NextToken();
            }
            else
            {
                Console.WriteLine("Error de sintaxis, se espera un " +espera);
                Log.WriteLine("Error de sintaxis, se espera un " +espera);
            }
        }
    }
}