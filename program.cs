using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;

namespace Class_Questions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers.");
            Method1();
        }
        static decimal Method1()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int[] inputArray = new int[number];

            if (inputArray.Length < 3)
            {
                return 0;
            }

            else if (inputArray.Length > 3)
            {
                return (inputArray[0] * inputArray[1] * inputArray[2]);
            }

            else if (inputArray != number)
            {
                return 1;
            }
        }

        //<summary>
            //This method will prompt the user to choose a number between 2-10, and will repeat for the amount of times equal to the number they entered. Then, it'll calculate the average of the numbers entered.
            //</summary>
        static decimal RandomNumberAverage()
        {
            Console.WriteLine("Please enter a number between 2 and 10.");
            int firstAmount = Console.ReadLine();

            for (i = 0; i < firstAmount; i++)
            {
                Console.WriteLine("Please enter another number between 2 and 10.");
                int[] inputArray = new int[firstAmount + 1];
            }
        }
    }
}
