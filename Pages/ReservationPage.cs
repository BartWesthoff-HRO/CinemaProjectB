using CinemaProjectB.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using CinemaProjectB.DAL;
using CinemaProjectB.Classes.Seats;

namespace CinemaProjectB.Pages
{
    class ReservationPage
    {

        public static void Run()
        {
            BaseSeat selectedSeat = SeatsPage.Run();
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
