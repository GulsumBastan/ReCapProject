using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,RentACarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join customer in context.Customers
                             on r.CustomerId equals customer.CustomerId
                join u in context.Users
                on customer.UserId equals u.Id
                             select new RentalDetailDto { Id = r.Id, CustomerId = r.CustomerId, FirstName = u.FirstName, LastName = u.LastName, BrandName = b.BrandName, DailyPrice = c.DailyPrice, RentDate = r.RentDate.Date, ReturnDate = r.ReturnDate, ModelYear = c.ModelYear };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
