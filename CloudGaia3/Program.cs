using System;
using System.Collections.Generic;

namespace CloudGaia3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var relationShip = new List<Tuple<string, string>>();
            var fd = new List<Tuple<string, string>>();
            List<PersonsAndCouple> personsAndCouple = new List<PersonsAndCouple>();

            personsAndCouple.Add(new PersonsAndCouple { name = "MARIA", couple = false });
            personsAndCouple.Add(new PersonsAndCouple { name = "JUAN", couple = false });
            personsAndCouple.Add(new PersonsAndCouple { name = "PEDRO", couple = false });
            personsAndCouple.Add(new PersonsAndCouple { name = "LUCAS", couple = false });




            personsAndCouple.Add(new PersonsAndCouple { name = "PAMELA", couple = true });
            personsAndCouple.Add(new PersonsAndCouple { name = "KEYLA", couple = true });

            Random random = new Random();

            for (int i = 0; i < personsAndCouple.Count; i++)
            {
                var coupleOne = personsAndCouple[random.Next(personsAndCouple.Count)];
                var coupleTwo = personsAndCouple[random.Next(personsAndCouple.Count)];


                if (coupleOne.couple != true || coupleTwo.couple != true)
                {
                    relationShip.Add(new Tuple<string, string?>(coupleOne.name, coupleTwo.name));
                }
                else
                {
                    Console.WriteLine($"{coupleOne.name} y {coupleTwo.name} no pueden ser parejas");
                }
            }

            foreach (var item in relationShip)
            {
                Console.WriteLine($"parejas : {item.Item1} y {item.Item2}");
            }
        }

        public class PersonsAndCouple {
            public string name { get; set; }
            public bool couple { get; set; }
        }
    }
}
/*
 
Script - Parejas

Escribe, en el lenguaje de programación que desees, un programa que reciba una lista de nombres y genere parejas aleatoriamente. 
El programa debe soportar también alguna estructura donde se puedan definir excepciones donde 2 nombres no pueden ser pareja.     

*/
