using CinemaProjectB.Classes.Seats;
using CinemaProjectB.DAL;
using CinemaProjectB.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB.Pages
{
    class SeatsPage
    {
        public static BaseSeat Run()
        {
            object[][] seats = new object[][]
            {
            new object[]{ new VipSeat(), new VipSeat() , new VipSeat()  },
            new object[]{ new VipSeat() , new VipSeat() , null },
            new object[]{ new VipSeat() , new VipSeat() , new MasterSeat() },
            };
            string prompt = "Welkom bij de Bioscoop";
            SeatsMenu zaal1 = new SeatsMenu(prompt, seats);
            zaal1.Display();
            BaseSeat selectedSeat = zaal1.Run();

            try
            {

                foreach (var item in DataStorageHandler.Storage.Reservations)
                {
                    if (selectedSeat.Row == item.Seats.Row && selectedSeat.Column == item.Seats.Column)
                    {
                        selectedSeat = null;
                        Run();
                    }
                }

            }
            catch (Exception) { };

            return selectedSeat;
        }
    }
}
