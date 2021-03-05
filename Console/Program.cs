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
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in car1.GetAll())
            //{
            //    // System.Console.WriteLine(car.Description);
            //    System.Console.WriteLine
            //        (
            //        "{0}---{1}",
            //         car.Description, car.ModelYear
            //        );

            //}

            foreach (var cars in carManager.GetCarDetails())
            {
                System.Console.WriteLine(cars.CarId+"\t"+cars.BrandName + "\t" +cars.ColorName);
            }

        }


    }
}
