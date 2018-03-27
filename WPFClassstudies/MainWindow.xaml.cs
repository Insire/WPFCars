using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModel;
using Engine;

namespace WPFClassstudies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Program _program;

        public Vehicles mycar = new Vehicles("SUV", "Blue", "SUVBlue");



        public MainWindow()
        {
            InitializeComponent();

            _program = new Program();

            DataContext = _program.parkinglot;

            //_program.parkinglot.ParkedCars.Add(mycar);

        }
    

        private void OnClick_AddCarRng(object sender, RoutedEventArgs e)
        {
            var Amount = 1;
            var myCar = Engine.Models.Factory.FabricateRng(Amount);
            _program.parkinglot.ParkedCars.Add(myCar);
        }
    }
}
