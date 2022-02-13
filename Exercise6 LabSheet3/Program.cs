using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_LabSheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of strings and create a simple LINQ query which displays the names to screen
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };



            var outputNames = from name in names
                              orderby name
                              where name.StartsWith("M")
                                select name;

            foreach (string n in outputNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
