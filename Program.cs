﻿using System;

namespace Sintaxis_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Lenguaje a = new Lenguaje();

                a.Programa();
                /*while(!a.FinArchivo())
                {
                    a.NextToken();
                }*/
                a.cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fin de compilacion");
            }
        }
    }
}