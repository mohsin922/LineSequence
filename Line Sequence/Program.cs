using System;

namespace Line_Sequence
{
    class Program
    {
        public double Linelength(double x1, double x2, double y1, double y2)
        {
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Math.Round(sqrt, 2));
            return Math.Round(sqrt, 2);
        }
        static void Main(string[] args)
        {
            int i;
            double x1, x2, y1, y2;
            double[] array = new double[2];
            for (i = 0; i < 2; i++)
            {


                Console.WriteLine("the value of x1 Co-Ordinate is : ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("the value of x2 Co-Ordinate is : ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("the value of y1 Co-Ordinate is : ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("the value of y2 Co-Ordinate is : ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Program p = new Program();
                Console.WriteLine("the length of the line " + i + "is : ");

                array[i] = p.Linelength(x1, x2, y1, y2);
            }
            if (array[0] == array[1])
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Both lines are  not equal");

            }
        }
    }
}



