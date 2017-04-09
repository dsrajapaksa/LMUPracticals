using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a value to be devide :");
                int devident = Convert.ToInt16(Console.ReadLine());
            
                Console.Write("Please enter a devider :");
                int devider = Convert.ToInt16(Console.ReadLine());

           
                int answerReturn = DivCal(devident, devider);

                Console.WriteLine("Answer of the calculation : {0}", answerReturn);
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You Cant Divide By Zero.. Stupid ! ");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please give Numbers not Strings :D");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Wrong Please Check Program !");
            }


            Console.ReadLine();
        }
        public static int DivCal(int num1, int num2)
        {
            int answer = num1 / num2;
            return answer;
        }

    }
}
