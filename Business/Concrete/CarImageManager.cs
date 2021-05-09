using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _ICarImagedal;

        public CarImageManager(ICarImageDal ıICarImage)
        {
            _ICarImagedal = ıICarImage;
        }

        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarImageLımıt(carImage.CarId));
            if (result!=null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.AddAsync(formFile);//burda ımagepathimize file helper yardımıyla dosyayı ekledik.
            carImage.Date = DateTime.Now;//tarihimize şuan ki saatten aldık.
            _ICarImagedal.Add(carImage);
            return new SuccessResult(Messages.AddedCarImages);

        }

        public IResult Delete(CarImage carImage)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _ICarImagedal.Get(p => p.Id == carImage.Id).ImagePath;
            IResult result = BusinessRules.Run(FileHelper.DeleteAsync(oldpath));

            if (result != null)
            {
                return result;
            }

            _ICarImagedal.Delete(carImage);
            return new SuccessResult(Messages.DeletedCarImage);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_ICarImagedal.GetAll());
        }

        public IDataResult<CarImage> GetById(int carid)
        {
            return new SuccessDataResult< CarImage>(_ICarImagedal.Get(c=>c.CarId==carid));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _ICarImagedal.Get(p => p.Id == carImage.Id).ImagePath;
            carImage.ImagePath = FileHelper.UpdateAsync(oldpath, file);
            carImage.Date = DateTime.Now;
            _ICarImagedal.Update(carImage);
            return new SuccessResult(Messages.UpdatedCarImage);
        }


        private IResult CheckCarImageLımıt(int carid)
        {
            var result= _ICarImagedal.GetAll(c => c.CarId == carid).Count;
            if (result>=5)
            {
                return new ErrorResult(Messages.CheckCarImageLımıt);  
            }
            return new SuccessResult();
        }
    }

    
}
