using System.Windows;

using Engine;
using Engine.ViewModel;

namespace WPFClassstudies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Vehicles mycar = new Vehicles("SUV", "Blue", "SUVBlue");

        private Program _program;
        public Program Program
        {
            get => _program;
            set => _program = value;
        }

        public MainWindow()
        {
            Program = new Program();

            DataContext = Program;

            InitializeComponent();
        }


        private void OnClick_AddCarRng(object sender, RoutedEventArgs e)
        {
            var Amount = 1;
            var myCar = Engine.Models.Factory.FabricateRng(Amount);
            Program.Parkinglot.ParkedCars.Add(myCar);
        }
    }
}
