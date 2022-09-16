using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
      
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {

                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             
                             select new CarDetailDto 
                             { 
                                 CarName = c.Name, 
                                 ColorName = co.Name,
                                 BrandName = b.Name, 
                                 DailyPrice = c.DailyPrice 
                             };

                return result.ToList(); 
            }
            

        }

        
    }
}
