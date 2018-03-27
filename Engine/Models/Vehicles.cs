using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Vehicles
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        //public int    Value { get; set; }

        public Vehicles(string model, string color, string image)
        {
            Model = model;
            Color = color;
            Image = image;
        }
    }
}
