﻿//

using Domain.Models;

namespace Application.Interfaces
{
    public interface IUniteOfWork:IDisposable
    {
        public IRepository<T> Repository<T>() where T:BaseEntity;
        public void Commit();
    }
}
