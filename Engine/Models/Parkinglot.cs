using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine
{
    public class Parkinglot
    {
        public ObservableCollection<Vehicles> ParkedCars { get; } = new ObservableCollection<Vehicles>();


    }
}
