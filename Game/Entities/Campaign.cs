using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    internal class Campaign:ICampaignService
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }

        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Adlı Kampanya Eklendi!");
        }

        public void RemoveCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Adlı Kampanya Silindi!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Adlı Kampanya Güncellendi!");
        }
    }
}
