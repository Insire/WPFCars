using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.ViewModel
{
    public class Program : BaseNotificationClass
    {
        public Parkinglot parkinglot = new Parkinglot();

        public int BlueCars => parkinglot.ParkedCars.Count(c => c.Color == "Blue");

        public int test { get; set; } = 10;

    }
}
