using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
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

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {

            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.CarDeleted);
        }
        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.CarUpdate);
        }
        public IDataResult <List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 20)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MeintenanceTime);
            //}
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }      
        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == Id));           
        }
        public IDataResult <List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId == colorId));

        }       
    }
}
