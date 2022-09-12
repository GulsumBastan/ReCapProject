﻿using DataAccess.Abstract;
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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2022,DailyPrice=50000,Description= "Motorlu ve Tekerlekli Kara Ulaşım Aracı"},
                new Car{Id=2,BrandId=2,ColorId=3,ModelYear=2022,DailyPrice=150000,Description="Motorlu ve Tekerlekli Kara Ulaşım Aracı"},
                new Car{Id=3,BrandId=3,ColorId=4,ModelYear=2022,DailyPrice=100000,Description="Motorlu ve Tekerlekli Kara Ulaşım Aracı" },
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=2022,DailyPrice=30000,Description="Motorlu ve Tekerlekli Kara Ulaşım Aracı"}

            };
        }



        public void Add(Car car)
        {

            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            throw new NotImplementedException();
        }

      

        public List<Car> GetAllByColor(int ColorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Equals(Id)).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);


            carToUpdate.Id = car.Id;



        }
    }
}