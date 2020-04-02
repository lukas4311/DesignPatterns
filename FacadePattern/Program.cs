using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("John Doe");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}
