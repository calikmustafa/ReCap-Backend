using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        //Constractor yapmamızın sebebi ICar(bu interfacei alan bütün classları new yapıp program cs de kullanabiliriz) türünde bir şey vericez Biz şuan inmemory verdik yarın
        //öbür gün eğer entitye geçersek EntityFramework vericez
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            
        }

        //Soyut Sınıfdan Referans almam gerek.

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
