using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Firma :IEntity
    {
        public int Id { get; set; }
        public string SirketAdi { get; set; }
    }
}
