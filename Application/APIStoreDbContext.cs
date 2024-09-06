using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//

namespace Application
{
    public class APIStoreDbContext:DbContext
    {
        public APIStoreDbContext(DbContextOptions dbContextOptions)
        :base(dbContextOptions){}

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<ProductsAttributes> ProductsAttributes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WishList> WishList { get; set; }

    }
}
