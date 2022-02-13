using System;
using System.Linq;

namespace LabSheet3_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            NumbersQuery();

            NumbersLambda();
           
          

        }

        private static void NumbersQuery() 
        {

            //LINQ  to retrieve data

            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outPutNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;
            foreach (int number in outPutNumbers)
            {
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine("****");
        }

        private static void NumbersLambda()
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine("****");
        }
    }
}
