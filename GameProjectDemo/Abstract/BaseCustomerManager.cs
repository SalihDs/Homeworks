using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Başarıyla Kayıt Olundu : " + customer.FirstName);
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt Silindi : " + customer.FirstName);
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Kayıt Güncellendi : " + customer.FirstName);
        }
    }
}
