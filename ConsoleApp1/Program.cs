using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Address someAddress = new Address();

            someAddress.Index = 18766;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kyiv";
            someAddress.Street = "Kolotyshkina";
            someAddress.House = 3;
            someAddress.Apartment = 66;

            Console.WriteLine(someAddress.GetAddress());


            Console.ReadKey();
        }
    }
}
