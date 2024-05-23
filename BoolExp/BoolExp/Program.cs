using System;


namespace BoolExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear;
            int apples = 6;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangePrice = 4.50m;

            Console.WriteLine(apples == oranges);
            Console.WriteLine(apples >= oranges);
            Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} < {oranges} is {apples < oranges}");
            Console.WriteLine($"{apples} >= {oranges} is {apples >= oranges}");
            Console.WriteLine($"{apples} <= {oranges} is {apples <= oranges}");
            Console.WriteLine($"{apples} is int is {oranges} is {apples is int}");
            Console.WriteLine($"Reducing apple cost: {(apples > oranges) && (applePrice > orangePrice)}"); // chyeck two conditions if both are true then true
            Console.WriteLine($"Reducing apple cost: {(apples > oranges) || (applePrice > orangePrice)}"); //check one conditions if one is tru the nalways trye

            bool moreApples;
            bool applesAreDearer;
            moreApples = (apples > oranges);
            applesAreDearer = (applePrice > orangePrice);
            Console.WriteLine($"We have more apples: {moreApples}");
            Console.WriteLine($"Apples are dearer: {applesAreDearer}");

            //Console.WriteLine($"Reducing cost apple: {moreApples && applesAreDearer}");
            //Console.WriteLine($"Reducing cost apple: {moreApples || applesAreDearer }");

            bool moreApplesAndDearer = moreApples && applesAreDearer;
            bool moreApplesOrDearer = moreApples || applesAreDearer;
            Console.WriteLine($"Reducing cost apples: {moreApplesAndDearer}");
            Console.WriteLine($"Reducing cost apples: {moreApplesAndDearer}");

            bool trueValue = true;
            bool falseValue = false;




        }
    }
}
