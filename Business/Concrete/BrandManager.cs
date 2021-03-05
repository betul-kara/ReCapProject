using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _ibranddal;

        public BrandManager(IBrandDal ibranddal)
        {
            _ibranddal = ibranddal;
        }
        public void Add(Brand brand)
        {
            _ibranddal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _ibranddal.Delete(brand);
        }

        public Brand Get(int id)
        {
            return _ibranddal.Get(b => b.BrandId == id);
        }

        public List<Brand> GetAll()
        {
            return _ibranddal.GetAll();
        }
        public void Update(Brand brand)
        {
            _ibranddal.Update(brand);
        }
    }
}
