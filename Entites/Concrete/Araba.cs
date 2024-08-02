using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public   class Araba : IEntity
    {
        public int Id { get; set; }
        public string  CekiciPlaka { get; set; }
        public string DorsePlaka { get; set; }
        

    }
}
