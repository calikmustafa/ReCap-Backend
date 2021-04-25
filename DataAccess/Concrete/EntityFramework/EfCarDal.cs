using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProjectDatabaseContext context=new CarProjectDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join d in context.Colors
                             on c.ColorId equals d.ColorId
                             select new CarDetailDto { CarName = c.CarName, ColorName = d.ColorName, BrandName = b.BrandName, CarId = c.CarId };
                return result.ToList();
            }
             
        }
    }
}
