using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    internal class Gamer:IGamerService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

        public void Delete(Gamer gamer)
        {

            Console.WriteLine("Kullanıcı Silindi");
        }

        public void Save(Gamer gamer)
        {
          
            Console.WriteLine("Kullanıcı Kaydedildi.Hoş Geldiniz Sayın / "+ gamer.Name + " " +gamer.Surname);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }
    }
}
