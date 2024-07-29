using Business.Abstract;
using Business.UnitOfWorks;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ArabaManager : IArabaService 
    {
       private readonly IArabaDal _arabaDal;
        private readonly IUnitOfWork _unitOfWork;

        public ArabaManager(IArabaDal arabaDal, IUnitOfWork unitOfWork)
        {
            _arabaDal = arabaDal;
            _unitOfWork = unitOfWork;
        }

        public void Add(Araba entity)
        {
            _arabaDal.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            Araba araba = _arabaDal.GetById(id);
            _arabaDal.Delete(araba);
            _unitOfWork.SaveChanges();
        }

        public List<Araba> GetAll()
        {
           return _arabaDal.GetAll();
        }

        public List<ArabaAndSurucuDto> GetAllArabaAndSurucuDtos(int surucuId)
        {
            return _arabaDal.GetAllBySurucuId(surucuId);
        }

        public Araba GetByCekiciPlaka(string cekiciPlaka)
        {
            return _arabaDal.Get(predicate: a => a.CekiciPlaka == cekiciPlaka);
        }

      

        public void Update(Araba entity)
        {
            Araba araba= _arabaDal.Get(predicate : a=>a.Id == entity.Id);
            araba.DorsePlaka = entity.DorsePlaka;
            araba.CekiciPlaka = entity.CekiciPlaka;
            _arabaDal.Update(araba);
            _unitOfWork.SaveChanges();
        }
    }
}
