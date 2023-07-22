using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetByBrandName(string name);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand>GetById(int brandId);      
        IResult Add(Brand brand);  
        IResult Update(Brand brand);   
        IResult Delete(Brand brand);

    }
}
