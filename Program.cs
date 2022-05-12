using System;

namespace Sintaxis_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lenguaje a = new Lenguaje();

            a.Programa();
            /*while(!a.FinArchivo())
            {
                a.NextToken();
            }*/
            a.cerrar();
        }
    }
}