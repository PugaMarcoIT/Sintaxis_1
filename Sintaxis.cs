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
                throw new Error("Error de sintaxis, se espera un " +espera, log);
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
                throw new Error("Error de sintaxis, se espera un " +espera, log);
            }
        }
    }
}