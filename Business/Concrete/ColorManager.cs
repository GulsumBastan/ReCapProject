using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        public List<Car> GetCarByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
