using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classpractice
{
    public class Hobby
    {
        //Field
        private string _hobbyname;
        private string _name;
        private string _author;
        private string _type;
        private int _pages;
        private double _price;

        public string Hobbyname { get => _hobbyname; set => _hobbyname = value; }
        public string Name { get => _name; set => _name = value; }
        public string Author { get => _author; set => _author = value; }
        public string Type { get => _type; set => _type = value; }
        public int Pages { get => _pages; set => _pages = value; }
        public double Price { get => _price; set => _price = value; }


        public Hobby(string hobbyname, string name, string author, string type, int pages, double price) //parameter constructor
        {

            this.Hobbyname = hobbyname;
            this.Name = name;
            this.Author = author;
            this.Type = type;
            this.Pages = pages;
            this.Price = price;
        }

       
    }//class
}//namespace
