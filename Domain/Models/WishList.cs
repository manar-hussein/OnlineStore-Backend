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
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }


        public DateTime DateAdded { get; set; }= DateTime.UtcNow;

        public  ICollection<Product>? Products { get; set; }

    }
}
