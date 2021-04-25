using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler implemente eden classların referans numarasını tutabilir.
            //CarTest();
            //BrandTest();
            DetailMethod();
        }

        private static void DetailMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.BrandName + "/" + item.ColorName + "/" + item.CarName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetById(2))
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetById(1))
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
