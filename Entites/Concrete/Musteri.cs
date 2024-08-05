using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Musteri :IEntity
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyAdi { get; set; }
        public string MusteriSıraNo { get; set; }
    }
}
