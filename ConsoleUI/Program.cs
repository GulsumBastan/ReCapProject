using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ColorDelete();
            //ColorUpdate();
            //ColorAdd();
            //ColorGetAll();
            //GetColorById();
            //BrandDelete();
            //BrandUpdate();
            //BrandAdd();
            //BrandGetAll();
            //GetBrandById();
            //GetCarsByColorId();
            //GetBrandById();
            //GetCarsByBrandId();
            //GetCarsByColorId();
            ////CarGetById();
            //CarGetAll();
            //CarDelete();
            //CarUpdate();
            //CarAdd();
            //CarTest();
            //ColorTest();
            //BrandTest();
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brands = brandManager.GetAll();
            foreach (var brand in brands.Data)
            {
                Console.WriteLine(brand.Id);
            }
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var colors = colorManager.GetAll();
            foreach (var color in colors.Data)
            {
                Console.WriteLine(color.Id);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
        }
        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { BrandId = 3, ColorId = 2, DailyPrice = 500, Description = "Tekerlekli Kara Ulaşım Aracı", ModelYear = 2009, Name = "Mercedes", UnitsInStock = 5 };
           var result= carManager.Add(car);
            Console.WriteLine(result.Message);
        }
        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { BrandId = 3, Id = 1003, ColorId = 2, DailyPrice = 500, Description = "Tekerlekli Kara Ulaşım Aracı", ModelYear = 2009, Name = "Mercedes", UnitsInStock = 5 };
            var result = carManager.Update(car);
            Console.WriteLine(result.Message);
        }
        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { Id = 2 };
            carManager.Delete(car);
            Console.WriteLine("İşlem Başarılı");
        }
        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Name);
            }
        }
        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(2);

            Console.WriteLine(result.Message);
        }
        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(3);
            foreach (var car in result.Data)
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(2);
            foreach (var car in result.Data)
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void GetBrandById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = brandManager.GetById(2);
            var data=brand.Data;
            Console.WriteLine(data.Name);
        }
        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Name);
            }
        }
        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Name = "Mercedes" };
            var result = brandManager.Add(brand);
            Console.WriteLine(result.Message);
        }
        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 2, Name = "Fiat" };
            var result = brandManager.Update(brand);
            Console.WriteLine(result.Message);
        }
        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 3 };
            var result = brandManager.Delete(brand);
            Console.WriteLine(result.Message);
        }
        private static void GetColorById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetById(2);
            Console.WriteLine(result.Data.Name);
        }
        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.Name);
            }
        }
        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Name = "Kırmızı" };
            var result = colorManager.Add(color);
            Console.WriteLine(result.Message);
        }
        private static void ColorUpdate()
        {
            ColorManager colormanager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 1, Name = "Beyaz" };
            var result = colormanager.Update(color);
            Console.WriteLine(result.Message);
        }
        private static void ColorDelete()
        {
            ColorManager colormanager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 2 };
            var result = colormanager.Delete(color);
            Console.WriteLine(result.Message);
        }
    }
}