using CinemaProjectB.DAL;
using CinemaProjectB.Pages;
using System;

namespace CinemaProjectB
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //Console.WriteLine("Hallo");
            //Console.ReadKey(true);
            //Console.Clear();
            //string naam = Beheer.Input("Wat is je naam?: ");
            //Console.WriteLine(naam);
            //Beheer.CreateAccount();
      
            DataStorageHandler.Init("ProjectB.json");
            WelcomePage.Run();
          


        }

     
        
    }
}
