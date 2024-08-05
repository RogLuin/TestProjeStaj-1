using Entites.Concrete;
using Entites.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        void Add(Musteri entity);
        void Update(Musteri entity);
        void Delete(int Id);
        Musteri GetByMusteriId(int musteriId);

        List<Musteri> GetAll();
    }
}
