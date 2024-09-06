using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//

namespace Domain.Models
{
    public class SubCategory : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
 
        public DateTime CreatedAt { get; set; }
    }
}
