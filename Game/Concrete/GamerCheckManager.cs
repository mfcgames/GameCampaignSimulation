using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    internal class GamerCheckManager : IGamerCheck
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {

            return true;
        }
    }
}
