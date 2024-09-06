using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class OrderDetails
    {
        public int Id { get; set; }
        public int  UserId { get; set; }
        public int  PaymentId { get; set; }
        public PaymentDetails payment {  get; set; } // ?
        public double Total { get; set; }
        public DateAndTime CreatedAt { get; set; }
    }
}
