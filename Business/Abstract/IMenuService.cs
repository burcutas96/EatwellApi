﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuService
    {
        IDataResult<List<Menu>> GetAll();
        IDataResult<Menu> Get(int id);
        IResult Add(Menu menu);
        IResult Delete(Menu menu);
        IResult Update(Menu menu);
    }
}
