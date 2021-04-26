using CinemaProjectB.Classes.Seats;

namespace CinemaProjectB.Classes
{
    public class Reservation
    {
        public string ID { get; set; } = "";
        public BaseSeat Seats { get; set; } = new BaseSeat(new Customer(), -1,-1,-1.00);
        public string Snack { get; set; }


    }
}
