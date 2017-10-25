using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_RoomMeasurements
{
    class Program
    {
        static void Main(string[] args)
        {
            // comment to test git

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            char userContinue = 'Y';
            do
            {
                Console.WriteLine("Please enter the length, width and height of a room at Grand Circus below.");

                /* (1) Ask the user for input and validate it */
                Console.Write("Enter the length of the room: ");
                double? len = Validate();
                

                Console.Write("Enter the width of the room: ");
                double? width = Validate();

                Console.Write("Enter the height of the room: ");
                double? height = Validate();

                if (len == null || width == null || height == null)
                {
                    Console.WriteLine("One of your values was invalid. Do you want to try again?");
                    Console.Write("'Y' to continue, or press any other key to stop: ");
                }
                else
                {
                    /* (2) Display the required metrics */
                    Console.WriteLine();
                    Console.WriteLine("Area: {0} sq. ft.", len * width);
                    Console.WriteLine("Perimeter: {0} feet", ((2 * len) + (2 * width)));
                    Console.WriteLine("Volume: {0} cubic feet", len * width * height);
                    Console.WriteLine();

                    Console.Write("Do you want measurements for another room? ('Y' to continue, or press any other key to stop): ");

                }
                
                
                userContinue = Console.ReadLine().ToLower()[0];
                Console.WriteLine();
            }
            while (userContinue == 'y');

            Console.WriteLine("Bye!");
        }

        public static double? Validate()
        {
            double x;
            bool valid = double.TryParse(Console.ReadLine(), out x);

            if (!valid)
            {
                return null;
            }

            return x;
        }
    }
}
