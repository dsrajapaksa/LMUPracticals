using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSomething();

            int value =  GetValue();
            Console.WriteLine("Value thrown by GetValue {0}", value);

           
            Console.WriteLine("Value thrown by GetCalculation {0}", GetCalculation(109, 200));


            Console.ReadLine();
        }
        //Method with No Returns
        static public void PrintSomething()
        {
            Console.WriteLine("Hi From Print Something Method !");
        }
        //Method with return Int
        static private int GetValue()
        {
            return 10;
        }

        //Method with Parameters
        static private double GetCalculation(double num1, double num2)
        {
            double total =  num2+num1;
            return total;
        }
    

    }
}
