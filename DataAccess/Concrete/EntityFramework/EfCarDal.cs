using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {

            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 ColorId = c.ColorId,
                                 BrandId = b.BrandId,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 CarImage =  context.CarImages.FirstOrDefault(f=>f.CarId==c.Id).ImagePath ?? "default.png"
                             };


                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}