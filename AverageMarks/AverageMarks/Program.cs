using System;
using System.Collections.Generic;

namespace AverageMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            double sum = 0;     
            string module;
            int userModule;
            int userMarks;
            Console.WriteLine("This program will calculate your average grade from your Marks");
            Console.WriteLine("===============================");
            do
            {
                
                Console.WriteLine("Only number is accepted\nEnter the Number of your module:");
                
            } while (!int.TryParse(Console.ReadLine(), out userModule));

            Console.WriteLine("You entered {0}", userModule);
            Console.WriteLine("===============================");





            while (true)
            {
                
                if (count == userModule)
                {
                    break;
                }
                
                Console.Write("Module{0} : \n", count + 1);
                module = Convert.ToString(Console.ReadLine());

                do
                {
                    // repeat until input is a number
                 Console.WriteLine("Only number is accepted, Enter your mark : ", count + 1);
                } while (!int.TryParse(Console.ReadLine(), out userMarks)) ;

                sum += userMarks;
                count++;
                
            }
            Console.WriteLine("===============================");
            Console.WriteLine("Average of yours Marks is {0}% ", (sum / userModule));
            Console.ReadKey();

        }   
    }
}
