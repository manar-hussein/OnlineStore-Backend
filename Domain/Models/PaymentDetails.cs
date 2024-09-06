using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PaymentDetails : BaseEntity
    {
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public OrderDetails? Order { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [StringLength(100)]
        public string Provider { get; set; } = null!;
        public PaymentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
