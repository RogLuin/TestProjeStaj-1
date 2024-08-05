using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMusteriDal : EfRepositoryBase<Musteri, TestProjeDbContext>, IMusteriDal
    {
        public EfMusteriDal(TestProjeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
