using GameProjectDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    interface ISaleService
    {
        void Sale(Customer customer, Game game, Campaign campaign);
        void Sale(Customer customer, Game game);
    }
}
