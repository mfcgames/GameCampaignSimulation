using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    internal class SellProduct:ISellService
    {
        public int SellId { get; set; }
        public int ProductPrice { get; set; }
        public string ProductName { get; set; }

        public void Sell(SellProduct sellProduct, Gamer gamer,Campaign campaign)
        {
             Console.WriteLine(sellProduct.ProductName+" Ürün "+campaign.CampaignName  + "Adlı Kampanya ile "+sellProduct.ProductPrice+" Tl fiyatla "+gamer.Name+" "+gamer.Surname+" Kişi Tarafından Satın Alındı."); ;
        }

        public void UpdatePrice(SellProduct sellProduct,Campaign campaign)
        {
            Console.WriteLine(ProductName+" isimli ürün "+campaign.CampaignName +" Kampanyasıyla Fiyatı : "+sellProduct.ProductPrice+" Olarak Güncellendi.");
        }
    }
}
