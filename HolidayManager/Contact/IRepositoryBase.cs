﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayManager.Contact
{
    public interface IRepositoryBase<T> where T:class
    {
        ICollection<T> FindAll();
        T FindById(string id);
        bool IsExits(string id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
