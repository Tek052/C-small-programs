using System;


namespace Accurancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double result1 = 0.1 * 8;
            double result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
            Console.WriteLine($"1st result is{result1:R}");
            Console.WriteLine($"2nd result is{result2:R}");

            double difference = result1 - result2;
            Console.WriteLine($"The difference betweeen is {difference:R}");

             
    }
}
