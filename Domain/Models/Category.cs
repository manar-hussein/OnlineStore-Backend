using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name{ get; set; }

        [StringLength(300)]
        public string Description{ get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Product>? Products { get; set; }
        public ICollection<SubCategory>? SubCategory { get; set; }

    }
}
