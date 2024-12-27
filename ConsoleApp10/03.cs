using System;

namespace ConsoleApp10
{
    public class Electonic
    {
        private string brand;
        protected int batery;
        private bool Ison;

        public string getbrand
        {
            get { return brand; }
            set { brand = value; }
        }

        public bool getIson
        {
            get { return Ison; }
            set { Ison = value; }
        }

        public int getBatery
        {
            get { return batery; }
            set { batery = value; }
        }

        public Electonic(string Brand, int Batery)
        {
            brand = Brand;
            batery = Batery;
            Ison = true;
            
        }

        public Electonic()
        {
            brand = "iphone 16 pro max";
            batery = 100;
            Ison = true;
        }

        public void turnoff()
        {
            Ison = false;
            Console.WriteLine($"this {brand} is turned off");
        }

        public void turnon()
        {
            Ison = true;
            Console.WriteLine($"this {brand}is turned on");
        }

        public void add(int level)
        {
            batery += level;
            if (batery > 100) batery = 100;
            Console.WriteLine($"this {brand} is added {batery} to batery");
        }
    }
}