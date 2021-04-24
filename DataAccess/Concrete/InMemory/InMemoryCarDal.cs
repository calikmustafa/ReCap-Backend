using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2008, DailyPrice = 120, Description = "Mercedes" },
            new Car { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = 2009, DailyPrice = 130, Description = "Audi" },
            new Car { CarId = 3, BrandId = 3, ColorId = 3, ModelYear = 2010, DailyPrice = 140, Description = "Porsche" },
            new Car { CarId = 4, BrandId = 4, ColorId = 4, ModelYear = 2011, DailyPrice = 150, Description = "Skoda" },
            new Car { CarId = 5, BrandId = 5, ColorId = 5, ModelYear = 2012, DailyPrice = 160, Description = "Bmw" },
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            //Bizim yukarıdaki listede silinecek elemanı bulmamız gerekiyor ve silinecek olan ürünle
            //aynı ıd ye sahip olması gerek
            //p listeyi gezicek ama hangi refaranstaki listeyi:Car
            Car CarToDelete = _car.SingleOrDefault(p=>p.CarId==car.CarId);
            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _car.Where(p => p.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(p=>p.CarId==car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}
