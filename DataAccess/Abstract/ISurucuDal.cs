using Core.DataAccess;
using Entites.Concrete;
using Entites.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISurucuDal : IRepository<Surucu>
    {
        List<FirmaAndSurcuDto> GetAllByFirmaId(int firmaId);
        List<SurucuAndArabaDto> GetAllByArabaId(int arabaId);
    }
}
