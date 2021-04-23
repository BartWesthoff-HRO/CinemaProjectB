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
            object[][] seats = new object[][]
            {
            new object[]{ new Seat(), new Seat() , new Seat()  },
            new object[]{ new Seat() , new Admin() , null },
            new object[]{ new Seat() , new Seat() , new Seat() },
            };
            string prompt = "Welkom bij de Bioscoop";
            SeatsMenu zaal1 = new SeatsMenu(prompt, seats);
            zaal1.Display();
            Seat selectedSeat = zaal1.Run();


            foreach (var item in DataStorageHandler.Storage.Reservations)
            {
                if (selectedSeat.Row == item.Seats.Row && selectedSeat.Column == item.Seats.Column)
                {
                    selectedSeat = null;
                    Run();
                    break;
                }
            }

            Reservation res = new Reservation
            {
                ID = "hallotest",
                Seats = selectedSeat,
            };

            if (res.Seats != null)
            {
                DataStorageHandler.Storage.Reservations.Add(res);
            }
            else { 
                // catch error
            }
           
            DataStorageHandler.SaveChanges();
        }


      
    }
}
