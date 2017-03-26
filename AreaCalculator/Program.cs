using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //double radius = 0, area = 0;
            ////const double PI = 3.14;

            //Console.WriteLine("Please enter the value of radius : ");
            //radius = Convert.ToDouble(Console.ReadLine());

            ////area = (22/7) * radius * radius - r^2 ;
            //area = Math.PI * Math.Pow(radius, 2);

            //Console.WriteLine("Area of the circle is : {0} ", area);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("No: 32, De Fonseka Avanue, Colombo");
            //sb.Append(", Sri Lanka");

            //sb.Replace("De Fonseka Avanue", "Flower Road");
            //sb.Remove(0, 10);

            //Console.WriteLine(sb);
            //Console.WriteLine(sb.Length);

            Console.Write("Please enter your email : ");
            string name = Console.ReadLine();
            string expression = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";


            var result = Regex.IsMatch(name, expression, RegexOptions.None);

            if(result==true)
            {
                Console.WriteLine("Email is correct !");
            }
            else
            {

                Console.WriteLine("Email is not correct ! ");
            }

            //Console.WriteLine(result);


            //Console.Write(@"Tell me yes\no ?");



            Console.ReadLine();
        }
    }
}
