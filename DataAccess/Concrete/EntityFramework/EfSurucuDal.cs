using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entites.Concrete;
using Entites.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSurucuDal : EfRepositoryBase<Surucu, TestProjeDbContext>, ISurucuDal
    {

        public EfSurucuDal(TestProjeDbContext dbContext) : base(dbContext)
        {

        }

        public List<SurucuAndArabaDto> GetAllByArabaId(int arabaId)
        {
            var query = from arabalarandsuruculer in _dbContext.ArabaSuruculer
                        join suruculer in _dbContext.Suruculer
                        on arabalarandsuruculer.SurucuId equals suruculer.Id
                        where arabalarandsuruculer.ArabaId == arabaId
                        select new SurucuAndArabaDto()
                        {
                            Adi = suruculer.Adi,
                            Soyadi = suruculer.Soyadi,
                            ArabaId = arabalarandsuruculer.ArabaId,
                            FirmaId = suruculer.FirmaId,
                            SurucuId = suruculer.Id,


                        };
            return query.ToList();
        }

        public List<FirmaAndSurcuDto> GetAllByFirmaId(int firmaId)
        {
            var query = from firmalar in _dbContext.Firmalar
                        join suruculer in _dbContext.Suruculer
                        on firmalar.Id equals suruculer.FirmaId
                        where firmalar.Id == firmaId
                        select new FirmaAndSurcuDto()
                        {
                            Adi = suruculer.Adi,
                            Soyadi = suruculer.Soyadi,
                            FirmaId = firmalar.Id,
                            SirketAdi = firmalar.SirketAdi,
                            SurucuId = suruculer.Id

                        };

            return query.ToList();
        }


    }
}
