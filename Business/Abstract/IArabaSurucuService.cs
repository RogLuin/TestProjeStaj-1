using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IArabaSurucuService
    {
        void Add(ArabaSurucu entity);
        void Delete(int id);
        void Update(ArabaSurucu entity );
        List<ArabaSurucu> GetAll();

        ArabaSurucu GetByArabaSurucuId(int surucuId);

    }
}
