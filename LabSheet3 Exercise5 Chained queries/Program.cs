using System;
using System.IO;
using System.Linq;


namespace LabSheet3_Exercise5_Chained_queries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = numbers
                .OrderByDescending(n => n);

            var query2 = query1
                .Where(n => n < 8);

            var query3 = query2
                .Select(n => DoubleIt(n));

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
                
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("Next result:  " + value.ToString() );
            return value * 2;
        }
    }
}
