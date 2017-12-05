using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of your object in Meters");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of your object in Meters");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine("The area of your object is: " + area + " Meters Squared");
            Console.ReadLine();

        }
    }
}