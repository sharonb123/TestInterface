using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use of constant variables by displaying them
            BusinessInfo businessInfo = new BusinessInfo();

            Console.WriteLine(businessInfo.businessName + "\n" + businessInfo.slogan);

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(businessInfo.businessName + " welcomes you to travel space with us");
            Console.WriteLine("We are giving you a budget of $" + businessInfo.budget + " to create your own journey through space.");
            Console.ReadLine();
        }
    }
}
