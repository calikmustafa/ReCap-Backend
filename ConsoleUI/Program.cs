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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            
            
           
        }
    }
}
