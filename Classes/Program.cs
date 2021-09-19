using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Salih";
            customer.LastName = "Dürüs";
            customer.City = "Isparta";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ali",
                LastName = "Dürüs",
                City = "Isparta"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
