using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            _ibranddal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _ibranddal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<Brand> Get(int id)
        {
            return new SuccessDataResult<Brand>(_ibranddal.Get(b => b.BrandId == id),true,Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_ibranddal.GetAll(),true,Messages.BrandsListed);
        }

        public IResult Update(Brand brand)
        {
            _ibranddal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
