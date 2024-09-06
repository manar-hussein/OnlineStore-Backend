using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class APIStoreDbContext:DbContext
    {
        public APIStoreDbContext(DbContextOptions dbContextOptions)
        :base(dbContextOptions){}
    }
}
