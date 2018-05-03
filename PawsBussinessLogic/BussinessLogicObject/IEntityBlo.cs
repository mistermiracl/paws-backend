﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsBussinessLogic.BussinessLogicObject
{
    public interface IEntityBlo<T>
    {
        int Insert(T toInsert);
        bool Update(T toUpdate);
        bool Delete(object id);
        T Find(object id);
        List<T> FindAll();
    }
}
