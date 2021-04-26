using CinemaProjectB.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using CinemaProjectB.DAL;

namespace CinemaProjectB.Pages
{
    class ReservationPage
    {

        public static void Run()
        {
            var selectedSeat = SeatsPage.Run();
            string snack = SnackPage.Run();
            Reservation res = new Reservation
            {
                ID = "hallotest",
                Seats = selectedSeat,
                Snack = snack,
            };
            DataStorageHandler.Storage.Reservations.Add(res);
            DataStorageHandler.SaveChanges();
        }


      
    }
}
