using DataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestProjeDbContext _dbContext;

        public UnitOfWork(TestProjeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
