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
    public class WishList : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User? User { get; set; }


        public DateTime DateAdded { get; set; }

        public  ICollection<Product>? Products { get; set; }

    }
}
