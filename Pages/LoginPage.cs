using CinemaProjectB.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using CinemaProjectB.DAL;

namespace CinemaProjectB.Pages
{
    class LoginPage
    {
        public static void Login()
        {
            Console.Clear();
            string Username = Beheer.Input("Wat is je gebruikersnaam?: ");
            string Password = Beheer.Input("Wat is je wachtwoord?: ");

            if (Username == "Bart" && Password == "Westhoff")
            {
                WelcomePage.Run();
            }
            else
            {
                Registreren();
            }
        }

        public static void Registreren()
        {
            Console.Clear();
            Customer Guest = new Customer
            {
                Firstname = Beheer.Input("Wat is uw voornaam?: "),
                Lastname = Beheer.Input("Wat is uw Achternaam?: "),

            };
            string MiddleName = Beheer.Input("Wat is uw tweede naam?: ");
            while (MiddleName != "Q" && MiddleName != "q")
            {
                Guest.MiddleName.Add(MiddleName);
                MiddleName = Beheer.Input("Wat is uw tweede naam?: ");
            }
            
            DataStorageHandler.Storage.Persons.Add(Guest);
            Console.ReadKey(true);
            WelcomePage.Run();
        }
    }
}
