using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class GSM
    {
        public string Model;
        public string Manufacturer;
        public int Price;
        public string Owner;
        private static string Nokian95;
        private string Colour;
        public string GetNokia()
        {
            return Nokian95;
        }
        public void Setnokia(string nokia)
        {
            Nokian95 = nokia;
        }
        public string GetColour()
        {
            return Colour;
        }
        public void SetColour(string colour)
        {
            Colour = colour;
        }
        public GSM(string model, string manufacterer,int price,string owner)
        {
            Model = model;
            Manufacturer = manufacterer;
            Price = price;
            Owner = owner;

        }
        public override string ToString()
        {
            return $"The price of this phone is {Price} and the owner is {Owner} manufacture in {Manufacturer} is model is {Model} ";
        }
        public void Printinfo()
        {
            string[] arr = { Model, Manufacturer, Price.ToString(), Colour };
            GetNokia();
        }

    }
    class Battery
    {
        public string Model;
        public int IdleTime;
        public int HourTalk;
        private string Original { get; set; }

        public Battery(string model,int idletime,int hourtalk)
        {
            Model = model;
            IdleTime = idletime;
            HourTalk = hourtalk;
        }
    }
    class Display
    {
        public int Size;
        public string Colour;
        private string Camera { get; set; }
        public Display(int size, string colour)
        {
            Size = size;
            Colour = colour;
            
        }
         

    }
}
