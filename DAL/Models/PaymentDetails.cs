using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class PaymentDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Amount {  get; set; }
        public string Provider {  get; set; }
        public string Status { get; set; }// enum 
        public DateAndTime CreatedAt { get; set; }
    }
}
