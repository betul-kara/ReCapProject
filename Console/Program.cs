using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = Core();

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    System.Console.WriteLine(c.CarId + " " + c.BrandName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }


        private static CarManager Core()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in car.GetAll())
            //{
            //    // System.Console.WriteLine(car.Description);
            //    System.Console.WriteLine
            //        (
            //        "{0}---{1}",
            //         car.Description, car.ModelYear
            //        );

            //}

            //foreach (var cars in carManager.GetCarDetails())
            //{
            //    System.Console.WriteLine(cars.CarId + "\t" + cars.BrandName + "\t" + cars.ColorName);
            //}

            return carManager;
        }
    }
}
