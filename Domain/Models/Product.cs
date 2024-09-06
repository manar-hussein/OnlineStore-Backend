//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product : BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(300)]
        public string Description { get; set; }=null!;

        public float Price {  get; set; }


        [StringLength(255)]
        public string Cover { get; set; } = null!;

        [ForeignKey(nameof(SubCategory))]
        public int SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
