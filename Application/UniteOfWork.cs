using Domain.RepositoryContracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class UniteOfWork : IUniteOfWork
    {
        private Hashtable _repositories;
        public UniteOfWork()
        {
            _repositories = new Hashtable();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            var key = typeof(T).Name;
            if(!_repositories.ContainsKey(key))
            {
                Repository<T> repository = new Repository<T>();
                _repositories[key] = repository;
            }
            return _repositories[key] as IRepository<T>;
            
        }
    }
}
