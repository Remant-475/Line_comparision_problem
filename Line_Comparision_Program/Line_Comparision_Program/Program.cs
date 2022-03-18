
using System;
namespace Line_Comparision_Program
{
    class program
    {
        public void ComparingLines()
        {
            Console.WriteLine("Welcome to Line Comparision program \n");
            Console.WriteLine("Enter the coordinates of first line \n");
            Console.WriteLine("Enter the value of x1:");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2 = int.Parse(Console.ReadLine());

             double LengthL1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line 1 : " + LengthL1);
        
           Console.WriteLine("Enter the coordinates of second line \n");

            Console.WriteLine("Enter the value of x3:");
            int x3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of x4:");
            int x4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y4 = int.Parse(Console.ReadLine());

            double LengthL2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of Line 2 :" + LengthL2);

            int lineStanding= LengthL1.CompareTo(LengthL2);

            if (lineStanding > 0)
            {
                Console.WriteLine("Line one is greater than line two");
            }
            else if (lineStanding < 0)
            {
                Console.WriteLine("Line two is greater than line one");
            }
            else
            {
                Console.WriteLine("Line one is equal to line two");
            }
        }
           public static void Main(String[]args)
           {
           program compare=new program();
            compare.ComparingLines();
           }
    }
}







