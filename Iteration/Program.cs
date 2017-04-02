using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            ////----FOR LOOPS------
            //for(int i=10; i>=0;i--)
            //{
            //    // Console.WriteLine(" {0} x 9 = {1} ", i,i*9);
            //    Console.WriteLine("Executes for the {0} time !", i);
            //}

            ////---FOR EACH LOOPS----------

            string[] names = { "Kamal", "Nimal", "Saman", "Sunil", "Amara" };

            ////Traditional way of looping through an array 

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("{0} Index name is : {1}", i, names[i]);
            //}

            ////Using for each to loop through the array !

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////--------WHILE LOOPS--------------

            //bool stat = true;
            //int counter = 0;

            //while(stat)
            //{
            //    Console.WriteLine("Counter Variable is : {0}", counter);

            //    if (counter == 10)
            //    {
            //        stat = false;
            //    }

            //    counter++;
            //}

            ////---WHILE LOOP EXAMPLE-----------

            Console.WriteLine("------ Grades Calculator ------");
       
            double marks = 0;
            int count = 0;
            string stats = "Y";
           
            while(stats=="Y")
            {
                Console.Write("Please enter marks of subject :");
                marks += Convert.ToDouble(Console.ReadLine());

                Console.Write("Do you have more marks ? (Y/N)");
                stats = Console.ReadLine();
                count++;
            }
            Console.WriteLine("Total Marks of all subjects : {0}", marks);
            Console.WriteLine("Average of marks : {0}", (marks / count));
        

            Console.ReadLine();
        }
    }
}
