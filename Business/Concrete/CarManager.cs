﻿using Business.Abstract;
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

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length >= 2 & car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }


        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


    }
}
