using Entites.Concrete;
using Entites.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISurucuService 
    {
        void Add(Surucu entity);
        void Update(Surucu entity);
        void Delete(int Id);
        List<FirmaAndSurcuDto> GetAllByFirmaId(int firmaId);
        List<SurucuAndArabaDto> GetAllByArabaId(int arabaId);
        

        Surucu GetBySurucuId( int SurucuId);

        List<Surucu> GetAll();
    }
}
