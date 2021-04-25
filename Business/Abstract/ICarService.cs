using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetById(int carId);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
