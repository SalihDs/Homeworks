using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Salih" },
                new Student{FirstName="Ali"},
                new Person{FirstName="Emre"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    interface IPerson { }
    class Customer : Person,IPerson
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
