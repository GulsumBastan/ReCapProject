using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal


    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=50000,Description= "Motorlu ve Tekerlekli Kara Ulaşım Aracı"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=150000,Description="Motorlu ve Tekerlekli Kara Ulaşım Aracı"},
                new Car{Id=3,BrandId=3,ColorId = 3,DailyPrice=100000,Description="Motorlu ve Tekerlekli Kara Ulaşım Aracı" },
                new Car{Id=4,BrandId=2,ColorId = 4,DailyPrice=30000,Description="Motorlu ve Tekerlekli Kara Ulaşım Aracı"}

            };
        }



        public void Add(Car car)
        {

            _cars.Add(car);
        }

        public List<CarDetailDto> CarDetails()
        {
            throw new NotImplementedException();
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

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);


            carToUpdate.Id = car.Id;



        }
    }
}
