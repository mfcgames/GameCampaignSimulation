using Game.Abstract;
using Game.Concrete;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Campaign campaign = new Campaign() { CampaignId=1,CampaignName="Dev Fırsat"};
            //Kampanya Ekleme
            campaign.AddCampaign(campaign);
            //Kampanya Güncelleme
            campaign.UpdateCampaign(campaign);

            //Ürün Ekleme Güncelleme.
            SellProduct sellProduct = new SellProduct() { ProductName="Cod BlackOps",ProductPrice=599};

            sellProduct.UpdatePrice(sellProduct,campaign);
          
            
            
            //Oyuncu Ekleme Kayıt...
            Gamer gamer = new Gamer() { Id=1,Name="Fethi",Surname="Çalışkan",DateOfBirth=new DateTime(1994,06,08),NationalityId="123456"};
            
            
            
            GamerCheckManager gamerCheck = new GamerCheckManager();
            //Oyuncu Gerçekmi Kontrol..
            if (gamer.Name=="Fethi")
            {
                gamerCheck.CheckIfRealPerson(gamer);
                gamer.Save(gamer);
            }
            else
            {
                Console.WriteLine("Yanlış Kullanıcı...");
            }
           

            

        }
    }
}
