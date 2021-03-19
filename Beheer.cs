using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB
{
    class Beheer
    {
        public static void Clear()
        {
            Console.Clear();           
        }
        public static string Input(string vraag = null)
        {
            if (vraag != null)
            {
                Console.WriteLine(vraag);
            }
            
            return Console.ReadLine();
        }
        public static void CreateAccount()
        {
            string naam = Input("Wat is je naam?: ");
            int Leetijd = int.Parse(Input("Wat is je leeftijd?: "));

            Console.WriteLine($"Naam {naam} leeftijd: {Leetijd}");
        }
    }
}
