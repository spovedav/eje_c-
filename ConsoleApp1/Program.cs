using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEMANA");
            Console.WriteLine("\tEJE.SEMANA.NUM => ejemplo de obtner el numero que esta la semana en el año");
            Console.WriteLine("\tEJE.SEMANA.RECORRIDO => ejemplo de para obtener el día en numero y día en string de la semana");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("INTERFACES");
            Console.WriteLine("\tEJE.INTERFACES.SENCILLA => ejemplo de como hacer una interfas sencilla pero se tiene que declarar por cada ves que se usa en el metodo");
            Console.WriteLine("\tEJE.INTERFACES.CON_INJECCION => pasar una interfas como como dependencia en un controlador de From1 : From");
            Console.WriteLine("\tEJE.INTERFACES.IREPOSITORY => ejemplo de como crear un servicio de IRepository");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("HELPER");

        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Ingres un nuemro");
            int numero = 0;
            bool bandera = false;
            int valordefualt = 5;
            try
            {
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0 || numero > 10)
                {
                    bandera = true;
                    numero = valordefualt;
                }
            }
            catch (Exception)
            {
                bandera = true;
                numero = valordefualt;
            }
           
            string ejeX = "X_X_X_X_X_";
            string ejeY = "_X_X_X_X_X";

            if (bandera)
            {
                Console.WriteLine("Se activo el valor por defecto: " + valordefualt);
            }
            
            for (int i = 1; i <= numero; i++)
            {
                if(!((i % 2) ==0))
                {
                    Console.WriteLine(ejeX.Substring(0,numero));
                }
                else
                {
                    Console.WriteLine(ejeY.Substring(0, numero));
                }
            }

            Console.ReadKey();
        }
        */
    }
}
