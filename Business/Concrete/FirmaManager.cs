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
    public class FirmaManager : IFirmaService
    {
        private readonly IFirmaDal _firmaDal;
        private readonly IUnitOfWork _unitOfWork;

        public FirmaManager(IFirmaDal firmaDal, IUnitOfWork unitOfWork)
        {
            _firmaDal = firmaDal;
            _unitOfWork = unitOfWork;
        }

        public void Add(Firma entity)
        {
            _firmaDal.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            Firma firma = _firmaDal.GetById(id);
            _firmaDal.Delete(firma);
            _unitOfWork.SaveChanges();
            
        }

        public List<Firma> GetAll()
        {
            return _firmaDal.GetAll();
        }

        public Firma GetByFirmaId(int id)
        {
           return _firmaDal.Get(predicate : a=>a.Id == id);
        }

       

        public void Update(Firma entity)
        {
            Firma firma = _firmaDal.Get(predicate : a=> a.Id == entity.Id);
            firma.Id = entity.Id;
            firma.SirketAdi = entity.SirketAdi;
            _unitOfWork.SaveChanges();
        }
    }
}
