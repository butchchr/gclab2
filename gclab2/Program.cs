using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab2
{
    class Program
    {
        static void Main(string[] args)

        {
            bool y = true;
            bool Y = true;
            while (y || Y == true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length: ");

                //takes the first user entry and assigns it as length and converts it to a double
                string length = Console.ReadLine();
                double doubleLength = Convert.ToDouble(length);

                //takes the second user entry, assigns it as width and converts it to a double
                Console.WriteLine("Enter Width: ");
                string width = Console.ReadLine();
                double doubleWidth = Convert.ToDouble(width);

                //Math for area and perimeter
                double area = doubleWidth * doubleLength;
                double perimeter = (doubleWidth * 2) + (doubleLength * 2);

                //Output
                Console.WriteLine("Area:" + area);
                Console.WriteLine("Preimeter:" + perimeter);

                Console.WriteLine("Continue? (y/n):");
                if (Console.ReadKey().KeyChar == 'y')
                {
                   y = true;
                }
                else
                {
                    y = false;
                }
            }
        }
    }
}
