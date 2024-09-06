using Application.Interfaces;
using Domain.Entities;

namespace Application.Repositories
{
    internal class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly APIStoreDbContext _context;
        public Repository(APIStoreDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
           throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
