using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFirmaService
    {
        void Add(Firma entity);
        void Delete(int id);
        void Update(Firma entity);
        List<Firma> GetAll();
        Firma GetByFirmaId(int id);
    }
}
