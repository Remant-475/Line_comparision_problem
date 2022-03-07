
using System;
namespace Line_Comparision_Program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome the Line Comparision program \n");
            Console.WriteLine("Enter the vaues of coordinates \n");
            Console.WriteLine("Enter the value of x1:");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2 = int.Parse(Console.ReadLine());

            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line :" + Length);

        }

    }
}







