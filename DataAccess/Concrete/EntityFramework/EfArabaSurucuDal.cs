using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArabaSurucuDal : EfRepositoryBase<ArabaSurucu, TestProjeDbContext>, IArabaSurucuDal
    {
        public EfArabaSurucuDal(TestProjeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
