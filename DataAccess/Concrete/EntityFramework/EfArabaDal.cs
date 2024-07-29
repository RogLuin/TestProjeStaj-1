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
    public class EfArabaDal : EfRepositoryBase<Araba, TestProjeDbContext>, IArabaDal
    {
        public EfArabaDal(TestProjeDbContext dbContext) : base(dbContext)
        {
        }

     

        public List<ArabaAndSurucuDto> GetAllBySurucuId(int surucuId)
        {
            var query = from arabalarandsuruculer in _dbContext.ArabaSuruculer
                        join arabalar in _dbContext.Arabalar
                        on arabalarandsuruculer.ArabaId equals arabalar.Id
                        where arabalarandsuruculer.SurucuId == surucuId
                        select new ArabaAndSurucuDto()
                        {
                            ArabaId = arabalar.Id,
                            SurucuId = arabalarandsuruculer.SurucuId,
                            CekiciPlaka = arabalar.CekiciPlaka,
                            DorsePlaka = arabalar.DorsePlaka,
                        };
            return query.ToList();
        }
    }
}
