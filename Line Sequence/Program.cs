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
        }
    }

        

}
    


        