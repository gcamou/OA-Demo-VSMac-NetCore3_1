using System;
using System.Collections.Generic;
using OA_DataAccess;
using OA_Repository;

namespace OA_Service
{
    public class ProductRepo : IProductRepo
    {
        IRepository<Product> _repositoty;
        public ProductRepo(IRepository<Product> repository)
        {
            _repositoty = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repositoty.GetAll();
        }

        public Product GetById(int id)
        {
            return _repositoty.GetById(id);
        }
    }
}
