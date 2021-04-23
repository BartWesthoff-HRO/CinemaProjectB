using System;
using System.Collections.Generic;
using System.Text;
using CinemaProjectB.Classes;
using CinemaProjectB.DAL;

namespace CinemaProjectB.Pages
{
    class WelcomePage
    {

        public static void Run()
        {
            DataStorageHandler.SaveChanges();
            Console.Clear();
            string prompt = "Welkom bij de Bioscoop";
            string[] options = { "Login", "Registreren", "Zaal bekijken" };
            ConsoleMenu StartPagina = new ConsoleMenu(prompt, options);
            StartPagina.DisplayOptions();
            int selectedIndex = StartPagina.Run();

            if (options[selectedIndex] == "Login")
            {
                LoginPage.Login();
            }
            else if (options[selectedIndex] == "Registreren")
            {
                LoginPage.Registreren();
            }
            else if(options[selectedIndex] == "Zaal bekijken")
            {
                ReservationPage.Run();
            }
            
        }

        
    }
}
