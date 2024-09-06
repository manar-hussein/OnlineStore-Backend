
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
    public class OrderDetails : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int  UserId { get; set; }
        public User? User { get; set; } 

        
        [ForeignKey("Payment")]
        public int  PaymentId { get; set; }
        public PaymentDetails? Payment {  get; set; }

        public ICollection<OrderItem> OrderItems {  get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
