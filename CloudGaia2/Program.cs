using System;

namespace CloudGaia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of array");
            string[] input = new string[10];
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i+1} value - ");
                input[i] = Console.ReadLine();
            }

            int getValue;
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == "#" || input[i] == "#")
                        {

                        }
                        else
                        {
                            if (Convert.ToInt32(input[i]) < Convert.ToInt32(input[j]))
                            {
                                getValue = Convert.ToInt32(input[i]);
                                input[i] = input[j];
                                input[j] = getValue.ToString();
                            }
                        }
                    }
                }
                foreach (var value in input)
                {
                    Console.Write($"{value} ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry you can only insert number and the character #");
            }
            

        }
    }
}
/*
 Dado un array de números desordenados y que contiene el carácter especial “#” N veces, escribe, 
 en el lenguaje de programación que desees, 
 un programa que permita leer dicho array y lo ordene de menor a mayor. 
 Las posiciones en las que se encuentra el carácter especial “#”, no deben ser modificadas.

Aclaración: Evitar el uso de funciones sort o de ordenamiento pertenecientes al lenguaje elegido.

Input: Lista de números desordenada con caracteres especiales

Output: Lista de números ordenada



Ejemplos:

1

*- Input: arr[] = {1, # ,6, 2, #, 3, 15};

*- Output: arr[] = {1, # ,2, 3, #, 6, 15};

2

*- Input: arr[] = {1, 9 , 2, #, #, 10, 3};

*- Output: arr[] = {1, 2 ,3,#, #, 9, 10}
     
     */
