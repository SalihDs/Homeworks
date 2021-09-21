using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.Name + " adlı Oyun "+customer.FirstName+" isimli müşteriye, "+
                campaign.Name + " Kampanyası ile "+ game.Price+" Tl yerine "+(game.Price-(campaign.Discount*game.Price/100)) +" Tl ile satılmıştır.");
        }

        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine(game.Name + " adlı Oyun " + customer.FirstName + " isimli müşteriye, " +
                game.Price+" Tl ile satılmıştır.");
        }
    }
}
