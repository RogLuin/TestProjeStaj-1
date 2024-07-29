using Entites.Concrete;
using Entites.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IArabaService
    {
        void Add(Araba entity);
        void Update(Araba entity);
        void Delete(int id);

        List<ArabaAndSurucuDto> GetAllArabaAndSurucuDtos(int surucuId);
        Araba GetByCekiciPlaka(string cekiciPlaka);
        List<Araba> GetAll();


    }
}
