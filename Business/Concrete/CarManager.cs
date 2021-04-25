using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Car> GetById(int carId)
        {
            return _carDal.GetAll(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.ColorId==colorId);
        }
    }
}
