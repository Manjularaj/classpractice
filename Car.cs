using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace classpractice
{
    public class Car
    {//Field
        public string _make;
        public string _model;
        public int _year;
        public string _color;
        public int _mileage;

        //Properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public Car(string make, string model, int year,string color, int mileage) //parameter constructor
        {

            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.Mileage = mileage;
            
     
        }
    }


    
}
