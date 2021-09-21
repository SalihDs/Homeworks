using GameProjectDemo.Adapter;
using GameProjectDemo.Concrete;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                FirstName = "Salih",
                LastName = "Dürüs",
                DateOfBirth = new DateTime(1999, 10, 24),
                NationalityId = "10000000000"
            };

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Add(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);

            Console.WriteLine("--------------");

            Campaign campaign = new Campaign { Name = "Herkes oyun oynasın", Discount = 20 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine("--------------");

            Game game = new Game { Name = "Far Cry 3", Price = 120 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            Console.WriteLine("--------------");

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(customer, game, campaign);
            saleManager.Sale(customer, game);

        }
    }
}
