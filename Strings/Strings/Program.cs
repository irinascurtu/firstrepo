using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello Batman";
            string mickey = "Hello Mickey Mouse";

            string result = myString + mickey;



            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();


            //for (int i = 0; i < 100000; i++)
            //{
            //    result += i;
            //}
            stopWatch1.Stop();
            Console.WriteLine($"With string:{stopWatch1.Elapsed}");

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            StringBuilder builder = new StringBuilder();
            builder.Append(result);

            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
               
            }
            stopWatch2.Stop();

            Console.WriteLine($"With stringBuilder;{stopWatch2.Elapsed}");


            if (myString == mickey)
            {
                Console.WriteLine("Mickey equals mystring");
            }
            string longString = "a, b, c, ddd, s, s";
            Console.WriteLine(longString);

            string replacedString = longString.Replace(",", ";");
            Console.WriteLine(replacedString);

            Console.WriteLine(myString.Remove(6, 6));

            Console.WriteLine(myString.Length);
            Console.WriteLine(myString[0]);

            Console.WriteLine(myString.Contains("M"));

            Console.WriteLine("Hello World!");

            decimal number = 12456664343;
            CultureInfo culture = new CultureInfo("en-us");
            Console.WriteLine(number.ToString("c", culture));


            CultureInfo india = new CultureInfo("ro-RO");
            Console.WriteLine(number.ToString("c", india));


        }
    }
}
