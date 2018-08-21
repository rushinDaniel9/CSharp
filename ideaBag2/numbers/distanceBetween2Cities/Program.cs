using System;

namespace distanceBetween2Cities {
    class Program {
        static void Main(string[] args) {
            /*
            Develop a program that calculates the distance between two cities and allows the user to specify a unit of distance.
            This program may require finding coordinates for the cities like latitude and longitude.
            */
            Console.WriteLine("NOTE: This application will only work if you provide the full address of the locations...");
            Console.WriteLine("\nPlease enter the first location here: ");
            var location1 = Console.ReadLine();
            Console.WriteLine("\nPlease enter the second location here: ");
            var location2 = Console.ReadLine();

            Console.WriteLine($"\nThe distance between location 1 and location 2 is: ");
            Console.ReadKey(true);
        }
    }
}
