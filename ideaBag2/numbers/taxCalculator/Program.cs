using System;

namespace taxCalculator {
    class Program {
        static void Main(string[] args) {
            /*
            Develop a program that asks the user to enter a cost and either a country or state tax.
            It then returns the tax plus the total cost with tax.
            */
            Console.WriteLine("Enter cost: ");
            var cost = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter tax percentage: ");
            var taxPercentage = Double.Parse(Console.ReadLine());

            var tax = (taxPercentage / 100) * cost;

            Console.WriteLine($"You are being taxed R{tax}.00, total cost(incl. tax) adds up to R{cost + tax}.00");
        }
    }
}
