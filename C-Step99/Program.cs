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
            int Array1 = Convert.ToInt32(Console.ReadLine());
            if (Array1 >= 0 && Array1 <= 6)
            {
                Console.WriteLine(Days[Array1]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You picked a number outside of the index.");
                Console.ReadLine();
            }


            int[] Number = { 56, 91, 1, 9, 82, 5 };
            Console.WriteLine("Pick a number between 0 and 5:");
            int Array2 = Convert.ToInt32(Console.ReadLine());
            if (Array2 >= 0 && Array2 <= 5)
            {
                Console.WriteLine(Number[Array2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You picked a number outside of the index.");
                Console.ReadLine();
            }

            List<string> Months = new List<string>();
            Months.Add("January");
            Months.Add("February");
            Months.Add("March");
            Months.Add("April");
            Months.Add("May");
            Months.Add("June");
            Months.Add("July");
            Months.Add("August");
            Months.Add("September");
            Months.Add("October");
            Months.Add("November");
            Months.Add("December");
            Console.WriteLine("Pick a number between 0 and 11:");
            int List1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Months[List1]);
            Console.ReadLine();
        }
    }
}
