using System.Collections.ObjectModel;

namespace Engine
{
    public class Parkinglot
    {
        public ObservableCollection<Vehicles> ParkedCars { get; } = new ObservableCollection<Vehicles>();
    }
}
