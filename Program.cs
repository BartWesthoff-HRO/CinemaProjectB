
using CinemaProjectB.DAL;
using CinemaProjectB.Pages;
using System;

namespace CinemaProjectB
{
    internal class Program
    {
        private static void Main(string[] args)
        {

       

            DataStorageHandler.Init("ProjectB.json");
            ReservationPage.Run();
          //  WelcomePage.Run();



        }



    }
}