using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class UniteOfWork : IUniteOfWork
    {
        private Hashtable _repositories;
        private readonly APIStoreDbContext _context;
        public UniteOfWork(APIStoreDbContext context)
        {
            _repositories = new Hashtable();
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        
        public IRepository<T> Repository<T>() where T : BaseEntity
        {
            var key = typeof(T).Name;
            if (!_repositories.ContainsKey(key))
            {
                Repository<T> repository = new Repository<T>(_context);
                _repositories[key] = repository;
            }
            return _repositories[key] as IRepository<T>;

        }
    }
}
