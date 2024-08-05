using Azure.Core;
using Business.Abstract;
using Business.UnitOfWorks;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private readonly IMusteriDal _musteriDal;
        private readonly IUnitOfWork _unitOfWork;
        public void Add(Musteri entity)
        {
           _musteriDal.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAll()
        {
            throw new NotImplementedException();
        }

        public Musteri GetByMusteriId(int musteriId)
        {
            throw new NotImplementedException();
        }

        public void Update(Musteri entity)
        {
            throw new NotImplementedException();
        }
    }
}
