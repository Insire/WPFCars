using System.Linq;

namespace Engine.ViewModel
{
    public class Program : BaseNotificationClass
    {
        public int BlueCars => Parkinglot.ParkedCars.Count(c => c.Color == "Blue");

        public int Test { get; set; } = 10;

        private Parkinglot parkinglot = new Parkinglot();
        public Parkinglot Parkinglot
        {
            get => parkinglot;
            set => parkinglot = value;
        }
    }
}
