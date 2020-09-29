using System;
using System.Collections.Generic;
using OA_DataAccess;

namespace OA_Service
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }
}
