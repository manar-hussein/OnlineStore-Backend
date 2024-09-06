//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category : BaseEntity
    {

        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(300)]
        public string Description{ get; set; }= null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<SubCategory>? SubCategory { get; set; }

    }
}
