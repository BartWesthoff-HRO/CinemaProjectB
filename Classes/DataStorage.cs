using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB.Classes
{
    public class DataStorage
    {
        public List<Customer> Persons { get; set; } = new List<Customer>();

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
