using System;
using System.Collections.Generic;
using OA_DataAccess;

namespace OA_Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
