using CinemaProjectB.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB.Pages
{
    public class SnackPage
    {
        public static string Run()
        {
            DataStorageHandler.SaveChanges();
            Console.Clear();
            string prompt = "Welkom bij de Bioscoop";
            string[] options = { "Popcorn Zoet", "Popcorn Zout", "Popcorn Mix" };
            ConsoleMenu StartPagina = new ConsoleMenu(prompt, options);
            StartPagina.DisplayOptions();
            int selectedIndex = StartPagina.Run();
            return options[selectedIndex];
        }
    }
}
