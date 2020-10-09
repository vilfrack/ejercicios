using System;

namespace CloudGaia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST CLOUD GAIA");
            for (int i = 1; i <= 100; i++)
            {
                string showText = string.Empty;
                if (i%3==0)
                {
                    showText = $"{i} - Cloud";
                }
                if (i % 5 == 0)
                {
                    showText = $"{i} - Gaia";
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    showText = $"{i} - CloudGaia";
                }

                if (showText == string.Empty)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(showText);
                }
                
            }
        }
    }
}

/*
 Escribe, en el lenguaje de programación que desees, 
 un programa que muestre en pantalla los números del 1 al 100, 
 sustituyendo los múltiplos de 3 por la palabra “Cloud” y, a su vez, los múltiplos de 5 por “Gaia”. 
 Para los que, al mismo tiempo, son múltiplos de 3 y 5, usar el combinado “CloudGaia”
 */
