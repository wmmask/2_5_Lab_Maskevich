using System;

namespace _2_5_Lab_Maskevich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            int num1 = int.Parse(userInput1);
            int num2 = int.Parse(userInput2);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);

            string myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);

            string userInputA = Console.ReadLine();
            string userInputB = Console.ReadLine();
            string userInputC = Console.ReadLine();
            int numA = int.Parse(userInputA);
            int numB = int.Parse(userInputB);
            int numC = int.Parse(userInputC);
            Console.WriteLine(numA * numB * numC);

            Console.WriteLine("Enter your age in years only");
            string myAge = Console.ReadLine();
            Console.WriteLine("You look younger than " + myAge + ".");


        }
    }
}
