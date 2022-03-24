using System;

namespace Metoder_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Count up");
            Console.WriteLine(CountUp());
            Console.WriteLine("Count down");
            Console.WriteLine(CountDown());
            Console.WriteLine("Count up with input");
            Console.WriteLine(InputCountUp(input));
            Console.WriteLine("Count down with input");
            Console.WriteLine(InputCountDown(input));

            

            Console.ReadKey();
        }

        public static string CountUp()
        {
            string output = "";
            for (int i = 1; i < 11; i++)
            {
                output += i + "\n";
            }

            return output;
        }

        public static string CountDown()
        {
            string output = "";
            for (int i = 10; i > 0; i--)
            {
                output += i + "\n";
            }

            return output;
        }

        public static string InputCountUp(int input)
        {
            string output = "";
            for (int i = 1 + input; i < 33 + input; i++)
            {
                output += i + "\n";
            }

            return output;
        }

        public static string InputCountDown(int input)
        {
            string output = "";
            for (int i = 16 + input; i > 0 + input; i--)
            {
                output += i + "\n";

            }

            return output;
        }




    }
}
