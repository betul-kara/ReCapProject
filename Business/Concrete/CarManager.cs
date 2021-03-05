using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icardal;

        public CarManager(ICarDal icarDal)
        {
            _icardal = icarDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _icardal.Add(car);
            }
            else
            {
                Console.WriteLine("2 karakterden fazla ve günlük fiyatı 0'dan büyük olmalı");
            }
            
        }

        public void Delete(Car car)
        {
            _icardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _icardal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _icardal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _icardal.GetAll().Where(b => b.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _icardal.GetAll().Where(c => c.ColorId == id).ToList();
        }

        public void Update(Car car)
        {
            _icardal.Update(car);
        }
    }
}
