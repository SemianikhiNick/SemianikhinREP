using System;

namespace PrSemianikhin1
{

    class Adress
    {
        public string city { get; set; }

        public string street { get; set; }

        public int nubmerHouse { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress London = new Adress() { city = "London", street = "Kings Road", nubmerHouse = 47 };
            Console.WriteLine("City: " + London.city + " Street: " + London.street + " NubmerHouse: " + London.nubmerHouse);
            Console.ReadKey();


            
        }
    }
}
