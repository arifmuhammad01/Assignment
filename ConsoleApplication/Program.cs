using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth:");
            string DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            string age = Console.ReadLine();

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t::::::Your Credentials::::::\n");
            Console.WriteLine("\tName:" + " " + name);
            Console.WriteLine("\tAddress:" + " " + address);
            Console.WriteLine("\tDate of Birth:" + " " + DateOfBirth);
            Console.WriteLine("\tAge:" + " " + age);
            Console.ReadKey();
        }
    }
}
