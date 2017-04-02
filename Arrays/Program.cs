using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalculator;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = { 13, 15, 17, 34, 20 };

            int[] ages = new int[5]
                {
                    10,
                    20,
                    30,
                    78,
                    20
                };

            //ages[0] = 14;
            //ages[1] = 30;
            //ages[2] = 89;
            //ages[3] = 30;
            //ages[4] = 20;
           

            Console.WriteLine(ages[3]);

            Dog dg = new Dog();

            Console.ReadLine();


        }
    }
}
