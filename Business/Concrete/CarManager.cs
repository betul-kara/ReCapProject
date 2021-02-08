using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icardal;

        public CarManager(ICarDal icardal)
        {
            _icardal = icardal;
        }

        public List<Car> GetAll()
        {
            return _icardal.GetAll();
        }
    }
}
