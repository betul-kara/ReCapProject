using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine( "Daily Price: "+ car.DailyPrice +"\n Model Year: "+ car.ModelYear +"\n");



            }
        }

        
    }
}
