using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Factory
    {
        public static List<string> Models = new List<string> { "Budget", "Sedam", "SUV" };
        public static List<string> Colors = new List<string> { "Black", "Blue", "Red" };

        public static Vehicles FabricateRng(int amount)
        {
            Random r = new Random();

            string m = Models[r.Next(0, Models.Count)]; // Get a random Model from our Models list
            string c = Colors[r.Next(0, Colors.Count)]; // Get a random color from our Color list
            string path = "/Engine;component/Assets/"; //
            string ext = ".png";                                // Define Image Adress for binding
            string i = path + m + c + ext;                      //

            Vehicles myCar = new Vehicles(m, c, i); // Instantiate new car class

            //BaseList.Add(myCar); // Store our car in our list

            return myCar;

        }

        public static Vehicles FabricateCustom(string Model, string Color, string Image)
        {
            Vehicles myCar = new Vehicles(Model, Color, Image);

            return myCar;

        }
    }
}
