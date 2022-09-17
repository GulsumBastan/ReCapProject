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
            foreach (var brand in brands)
            {
                Console.WriteLine(brand.Id);
            }
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var colors = colorManager.GetAll();
            foreach (var color in colors)
            {
                Console.WriteLine(color.Id);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var cars = carManager.GetCarDetails();

            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
        }
        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { BrandId = 3, ColorId = 2, DailyPrice = 500, Description = "Tekerlekli Kara Ulaşım Aracı", ModelYear = 2009, Name = "Mercedes", UnitsInStock = 5 };
            carManager.Add(car);
            Console.WriteLine("İşlem Başarılı");
        }
        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = new Car { BrandId = 3, Id = 1003, ColorId = 2, DailyPrice = 500, Description = "Tekerlekli Kara Ulaşım Aracı", ModelYear = 2009, Name = "Mercedes", UnitsInStock = 5 };
            carManager.Update(car);
            Console.WriteLine("İşlem Başarılı");
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
            var cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }
        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = carManager.GetById(2);

            Console.WriteLine(car.Name);
        }
        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetCarsByColorId(3);
            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }
        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetCarsByBrandId(2);
            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }
        private static void GetBrandById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = brandManager.GetById(2);
            Console.WriteLine(brand.Name);
        }
        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brands = brandManager.GetAll();
            foreach (var brand in brands)
            {
                Console.WriteLine(brand.Name);
            }
        }
        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Name = "Mercedes" };
            brandManager.Add(brand);
            Console.WriteLine("İşlem Başarılı");
        }
        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 2, Name = "Fiat" };
            brandManager.Update(brand);
            Console.WriteLine("İşlem Başarılı");
        }
        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = new Brand { Id = 3 };
            brandManager.Delete(brand);
            Console.WriteLine("İşlem Başarılı");
        }
        private static void GetColorById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = colorManager.GetById(2);
            Console.WriteLine(color.Name);
        }
        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var colors = colorManager.GetAll();
            foreach (var color in colors)
            {
                Console.WriteLine(color.Name);
            }
        }
        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Name = "Kırmızı" };
            colorManager.Add(color);
            Console.WriteLine("İşlemBaşarılı");
        }
        private static void ColorUpdate()
        {
            ColorManager colormanager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 1, Name = "Beyaz" };
            colormanager.Update(color);
            Console.WriteLine("İşlem Başarılı");
        }
        private static void ColorDelete()
        {
            ColorManager colormanager = new ColorManager(new EfColorDal());
            var color = new Color { Id = 2 };
            colormanager.Delete(color);
            Console.WriteLine("İşlem Başarılı");
        }
    }
}