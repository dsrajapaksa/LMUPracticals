using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Area of the Circle is : {0}", GetArea(5.0));

            int number=0;
            bool value=false;

            Console.WriteLine("Before Calling method RefParameters() number = {0},Value={1}",
                number, value);

            RefParameters(10, ref number,ref value);

            Console.WriteLine("After Calling method RefParameters() number = {0},Value={1}",
                number, value);

            Console.ReadLine();
        }

        //Get area of a square
        public static double GetArea(double height, double width)
        {
            double area = height * width;
            return area;
        }

        //Get area of a Circle
        public static double GetArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        //Get area of a Circle for Int Input 
        public static double GetArea(int radius)
        { 
            int area = Convert.ToUInt16( Math.PI * Math.Pow(radius, 2));
            return area;
        }

        //Returning more than one value 
        public static int RefParameters(int radius, ref int a, ref bool b )
        {
            //Doing Something here ! 
            a = 10;
            b = true;
            return 0 ;
        }








    }
}
