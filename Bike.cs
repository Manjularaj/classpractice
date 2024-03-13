using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classpractice
{
    internal class Bike
    {//Field
        public string _brand;
        public string _type;
        public string _color;
        public int _numberofwheels;

        //Properties
        public string Brand { get => _brand; set => _brand = value; }
        public string Type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public int Numberofwheels { get => _numberofwheels; set => _numberofwheels = value; }



        public Bike(string brand, string type, string color, int numberofwheels) //parameter constructor
        {

            this.Brand = brand;
            this.Type = type;
            this.Color = color;
            this.Numberofwheels = numberofwheels;

        }

        
    }//cclass
}//namespace
