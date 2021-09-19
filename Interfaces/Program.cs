using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());

            List<ICustomerDal> customerDals = new List<ICustomerDal>{
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customerDals);
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Salih",
                LastName = "Dürüs",
                Address = "Isparta"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Ali",
                LastName = "Dürüs",
                Departmant = "Computer Sciences"
            };

            PersonManager personManager = new PersonManager();
            personManager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worke : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
