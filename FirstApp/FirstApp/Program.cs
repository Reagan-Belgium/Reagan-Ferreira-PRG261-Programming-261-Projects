using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
                string fName = Console.ReadLine();

            Console.WriteLine("Enter student number");
                int sNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student fees");
                double fees = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you diploma: true or false");
                bool check = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Student: " + fName + " has student number: " + sNumber);
            Console.WriteLine("Student is diploma: " + check + " and pays fees: " + fees);
            Console.ReadKey();


            Console.WriteLine("Test to see if the push works");
        }
    }
}
