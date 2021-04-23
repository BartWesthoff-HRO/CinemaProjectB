using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB.Classes
{
    public class Reservation
    {
        public string ID { get; set; } = "";
        public Seat Seats { get; set; } = new Seat();


    }
}
