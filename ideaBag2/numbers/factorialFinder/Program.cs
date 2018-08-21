using System;

namespace factorialFinder {
    class Program {
        static void Main(string[] args) {
            /*
            The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2, ...1.
            Develop a program that solves the factorial of any user given number using both loop and recursion.
            */
            Console.WriteLine("Enter the number you want the factorial for(number must be an integer): ");
            int factorialInt = Int32.Parse(Console.ReadLine());
            int i = 1;
            int[] factorialArray = new int[factorialInt];

            while(i <= factorialInt) {
                factorialArray.add(i);
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(factorialArray);
        }
    }
}
