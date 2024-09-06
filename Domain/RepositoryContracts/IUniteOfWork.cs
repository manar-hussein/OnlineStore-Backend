﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryContracts
{
    public interface IUniteOfWork
    {
        public IRepository<T> Repository<T>() where T:class;
        public void Commit();
    }
}
