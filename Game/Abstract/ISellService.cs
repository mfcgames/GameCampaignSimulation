using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Abstract
{
    internal interface ISellService
    {
        void Sell(SellProduct sellProduct,Gamer gamer,Campaign campaign);
        void UpdatePrice(SellProduct sellProduct,Campaign campaign);
    }
}
