using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OA_DataAccess;

namespace OA_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> entity;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entity.FirstOrDefault(t => t.Id == id);
        }
    }
}