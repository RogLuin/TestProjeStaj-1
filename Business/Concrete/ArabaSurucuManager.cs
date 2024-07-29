using Business.Abstract;
using Business.UnitOfWorks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ArabaSurucuManager : IArabaSurucuService
    {

        private readonly IArabaSurucuDal _arabaSurucuDal;
        private readonly IUnitOfWork _unitOfWork;

        public ArabaSurucuManager(IArabaSurucuDal arabaSurucuDal, IUnitOfWork unitOfWork)
        {
            _arabaSurucuDal = arabaSurucuDal;
            _unitOfWork = unitOfWork;
        }

        public void Add(ArabaSurucu entity)
        {
            _arabaSurucuDal.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
           ArabaSurucu arabaSurucu = _arabaSurucuDal.GetById(id);
            _arabaSurucuDal.Delete(arabaSurucu);
            _unitOfWork.SaveChanges();

        }

        public List<ArabaSurucu> GetAll()
        {
            return _arabaSurucuDal.GetAll();
        }

        public ArabaSurucu GetByArabaSurucuId(int surucuId)
        {
            return _arabaSurucuDal.Get(predicate: a => a.SurucuId == surucuId);
        }

       

        public void Update(ArabaSurucu entity)
        {
            ArabaSurucu arabaSurucu = _arabaSurucuDal.Get(predicate: a => a.Id ==entity.Id);
            arabaSurucu.Id = entity.Id;
            arabaSurucu.ArabaId = entity.ArabaId;
            arabaSurucu.SurucuId = entity.SurucuId;
            _unitOfWork.SaveChanges();
            
        }
    }
}
