using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            ////---Temperature Program ---- :D 

            //Console.Write("What is the temperature out ? ");

            //int temp = Convert.ToInt16(Console.ReadLine());


            //if(temp >= 25)
            //{
            //    Console.WriteLine("Its too HOT there ! ");
            //}
            //else if(temp >=10 && temp <25)
            //{
            //    Console.WriteLine("Its cool :D! ");
            //}
            //else
            //{
            //    Console.WriteLine("Its FRZEEING ZZZ!");
            //}

            //--------Marks Program----- :D 

            //Console.Write("How is your marks for exam ? ");
            //int marks = Convert.ToInt16(Console.ReadLine());

            //if (marks > 75 && marks <= 100)
            //{
            //    Console.WriteLine("Awesome you got A !");
            //}
            //else if (marks > 65 && marks < 74)
            //{
            //    Console.WriteLine("Cool you got B!");
            //}
            //else if (marks > 55 && marks < 64)
            //{
            //    Console.WriteLine("Work more harder you got C !");
            //}
            //else if (marks > 0 && marks < 54)
            //{
            //    Console.WriteLine("Gosh you faild !");
            //}
            //else
            //{
            //    Console.WriteLine(" What the hell ... ! ");
            //}

            //------SWITCH CASE CONDITIONS----------------
            Console.Write("Please enter a Letter : ");
            string letter = Console.ReadLine();

            switch (letter.ToUpper())
            {
                case "A":
                    Console.WriteLine("A is for Apple !");
                    break;
                case "B":
                    Console.WriteLine("B is for Ball !");
                    break;
                case "C":
                    Console.WriteLine("C is for Cat !");
                    break;
                default:
                    Console.WriteLine("There's no such letter exsist :( ");
                    break;
            }


            Console.ReadLine();
        }
    }
}
