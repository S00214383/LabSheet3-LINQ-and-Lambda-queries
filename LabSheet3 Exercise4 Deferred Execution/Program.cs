using System;
using System.Linq;
using System.IO;

namespace LabSheet3_Exercise4_Deferred_Execution
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            //  var query = from number in numbers
            //              select DoubleIt(number);

            var query = numbers
                .Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach Loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number" + value.ToString());
            return value * 2;
        }
    }
}
