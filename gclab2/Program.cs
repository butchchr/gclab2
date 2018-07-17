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
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            bool y = true;
            while (y)
            {
                //user input section

                Console.WriteLine("Enter Length: ");
                string length = Console.ReadLine();

                Console.WriteLine("Enter Width: ");
                string width = Console.ReadLine();

                //added the extra challenge volume calc and needed user input
                Console.WriteLine("Enter height (if not using height enter 1): ");
                string height = Console.ReadLine();

                //even though the assignment says we are given numbers I still put in a check
                decimal dLength;
                decimal dWidth;
                decimal dHeight;
                bool num1 = decimal.TryParse(length, out dLength);
                bool num2 = decimal.TryParse(width, out dWidth);
                bool num3 = decimal.TryParse(height, out dHeight);
                if (!(num1 && num2 && num3))
                {
                    Console.WriteLine("You did not enter numbers");
                    break;
                }

                //Math for area, perimeter, and volume
                decimal area = dWidth * dLength;
                decimal perimeter = (dWidth * 2) + (dLength * 2);
                decimal volume = dWidth * dLength * dHeight;

                //Output
                Console.WriteLine("Area:" + area);
                Console.WriteLine("Perimeter:" + perimeter);
                Console.WriteLine("Volume: " + volume);

                //The magic y/n loop until y or n is pressed. When I got home from class
                //I wanted to change something and caught that while you could press y or n
                //n did not actually exit the program as I wasn't reading the keystroke properly
                bool invalid = true;
                while (invalid)
                {
                    Console.WriteLine("Continue? (y/n):");
                    ConsoleKeyInfo pressed = Console.ReadKey();
                    Console.WriteLine();
                    bool isY = pressed.Key == ConsoleKey.Y;
                    bool isN = pressed.Key == ConsoleKey.N;

                    invalid = !isY && !isN;
                    y = isY;
                }
            }
        }
    }
}
