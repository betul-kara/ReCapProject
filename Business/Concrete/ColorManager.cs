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
    public class ColorManager : IColorService
    {
        IColorDal _icolordal;
        public ColorManager(IColorDal icolordal)
        {
            _icolordal = icolordal;
        }

        public IResult Add(Color color)
        {
            _icolordal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _icolordal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<Color> Get(int id)
        {
            return new SuccessDataResult<Color>(_icolordal.Get(c => c.ColorId == id));
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_icolordal.GetAll());
        }

        public IResult Update(Color color)
        {
            _icolordal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
