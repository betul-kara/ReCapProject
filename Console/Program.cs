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
            CarManager car1 = new CarManager(new EfCarDal());


            car1.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 10, Description = "qwerty", ModelYear = 2010 });


            foreach (var car in car1.GetAll())
            {
                // System.Console.WriteLine(car.Description);
                System.Console.WriteLine
                    (
                    "{0}---{1}",
                     car.Description, car.ModelYear
                    );

            }

        }


    }
}
