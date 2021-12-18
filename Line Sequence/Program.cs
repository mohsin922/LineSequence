using System;

namespace Line_Sequence
{
    class program
    {
        public static double Length(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Please Enter X1 and Y1 Co-Ordinates:");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter X2 and Y2 Co-Ordinates:");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            var result = Length(x1, x2, y1, y2);
            Console.WriteLine("Length of line between cordinates {0},{1} and {2},{3} is {4}", x1, y1, x2, y2, result);


            Console.WriteLine("Please Enter X3 and Y3 Co-Ordinates:");
            var x3 = Convert.ToDouble(Console.ReadLine());
            var y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter X4 and Y4 Co-Ordinates:");
            var x4 = Convert.ToDouble(Console.ReadLine());
            var y4 = Convert.ToDouble(Console.ReadLine());
            var result1 = Length(x3, x4, y3, y4);
            Console.WriteLine("Length of line between cordinates {0},{1} and {2},{3} is {4}", x3, y3, x4, y4, result1);
            if( result == result1)
            {
                Console.WriteLine("Lines are equal");
            }
            else if(result > result1)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else  
            {
                Console.WriteLine("Line 1 is Lesser than Line 2");
            }
           
        }
    }



}