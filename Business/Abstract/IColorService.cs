﻿using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetByColorName(string name);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);      
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);


    }
}
