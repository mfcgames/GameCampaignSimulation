using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Abstract
{
    internal interface ICampaignService
    {
        void UpdateCampaign(Campaign campaign);
        void AddCampaign(Campaign campaign);
        void RemoveCampaign(Campaign campaign);

    }
}
