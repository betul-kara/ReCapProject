using Business.Abstract;
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
        public void Add(Color color)
        {
            _icolordal.Add(color);
        }

        public void Delete(Color color)
        {
            _icolordal.Delete(color);
        }

        public Color Get(int id)
        {
            return _icolordal.Get(c => c.ColorId == id);
        }

        public List<Color> GetAll()
        {
            return _icolordal.GetAll();
        }

        public void Update(Color color)
        {
            _icolordal.Update(color);
        }
    }
}
