using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class ArabaSurucu :IEntity
    {
        public  int Id { get; set; }
        public int ArabaId { get; set; }
        public int SurucuId { get; set; }

    }
}
