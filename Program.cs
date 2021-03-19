using System;

namespace CinemaProjectB
{
    class Program
    {
        static void Main(string[] args)
        {

            //Beheer.Clear();
            //string naam = Beheer.Input("Wat is je naam?: ");
            //Console.WriteLine(naam);
            //Beheer.CreateAccount();
            MainMenu();
        }

        public static void MainMenu()
        {
            string prompt = "Welkom bij de Bioscoop";
            string[] options = { "Login", "Registreren" };
            Menu StartPagina = new Menu(prompt, options);
            StartPagina.DisplayOptions();
            int selectedIndex = StartPagina.Run();

            if (selectedIndex == 0)
            {
                Login();
            }
            else if (selectedIndex == 1)
            {
                Registreren();
            }
        }
        public static void Login()
        {
            Console.WriteLine("Ingelogd");
            Console.ReadKey(true);
            MainMenu();
        }
        public static void Registreren()
        {
            Console.WriteLine("Registeren");
            Console.ReadKey(true);
            MainMenu();
        }
    }
}
