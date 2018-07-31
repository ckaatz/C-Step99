using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step99
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Pick a number between 0 and 6:");
            Console.WriteLine(Days[Convert.ToInt32(Console.ReadLine())]);
            Console.ReadLine();

            int[] Number = { 56, 91, 1, 9, 82, 5 };
            Console.WriteLine("Pick a number between 0 and 5:");
            Console.WriteLine(Number[Convert.ToInt32(Console.ReadLine())]);
            Console.ReadLine();
        }
    }
}
