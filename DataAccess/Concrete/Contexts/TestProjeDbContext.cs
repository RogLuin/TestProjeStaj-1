using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Contexts
{
    public class TestProjeDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Surucu> Suruculer { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<ArabaSurucu> ArabaSuruculer { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        public TestProjeDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated();

        }
    }
}
