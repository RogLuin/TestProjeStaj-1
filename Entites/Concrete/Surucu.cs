using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Surucu : IEntity
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public string Adi { get; set; }
        public string Soyadi{ get; set; }



    }
}
