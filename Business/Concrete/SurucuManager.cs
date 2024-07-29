using Business.Abstract;
using Business.UnitOfWorks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using Entites.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SurucuManager : ISurucuService
    {

        private readonly ISurucuDal _surucuDal;
        private readonly IUnitOfWork _unitOfWork;

        public SurucuManager(ISurucuDal surucuDal, IUnitOfWork unitOfWork)
        {
            _surucuDal = surucuDal;
            _unitOfWork = unitOfWork;
        }

        public void Add(Surucu entity)
        {
            _surucuDal.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int Id)
        {
            Surucu surucu = _surucuDal.GetById(Id);
            _surucuDal.Delete(surucu);
            _unitOfWork.SaveChanges();
        }

        public List<Surucu> GetAll()
        {
            return _surucuDal.GetAll();
        }

        public List<SurucuAndArabaDto> GetAllByArabaId(int arabaId)
        {
            return _surucuDal.GetAllByArabaId(arabaId);
        }

        //public List<ArabaAndSurucuDto> GetAllArabaAndSurucuDtos(int surucuId)
        //{
        //    return _surucuDal.GetAllByAraba(surucuId);
        //}

        public List<FirmaAndSurcuDto> GetAllByFirmaId(int firmaId)
        {
            return _surucuDal.GetAllByFirmaId(firmaId);
        }

        public Surucu GetBySurucuId(int Id)
        {
            return _surucuDal.Get(predicate: a => a.Id == Id);
        }

        public void Update(Surucu entity)
        {
            Surucu surucu = _surucuDal.Get(predicate: a => a.Id == entity.Id);
            surucu.Id = entity.Id;
            surucu.Adi = entity.Adi;
            surucu.Soyadi = entity.Soyadi;
            _unitOfWork.SaveChanges();
        }

     
    }
}
