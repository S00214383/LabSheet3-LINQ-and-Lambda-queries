using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet3_Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCustomers();

              
        }

        private static List<Customer> GetCustomers()
        {
            //creating customer and its properties
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            //adding customers to the list
            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);


            var query1 = customers
                .Where(result => result.City.ToLower() == "dublin" || result.City.ToLower() == "galway") // extracting from city property
                .OrderBy(result => result.Name); //ordering by name



                foreach (var name in query1)
            {
               Console.WriteLine(name.Name);
            }
            return customers;
            
           

        }
      



    }
   
}
