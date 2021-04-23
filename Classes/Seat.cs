using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB.Classes
{
    public class Seat
    {
        public bool IsBooked { get; set; }
        public Person BookedBy { get; set; }
        public double Price { get; set; }
      //  public string Icon { get; set; } = "[*]";
        public int Row { get; set; } = -1;
        public int Column { get; set; } = -1;
    }
}
