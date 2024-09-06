//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Address : BaseEntity
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }


        public string Street { get; set; } = null!;
        public string City { get; set; }=null!;
        public string PhoneNumber { get; set; } = null!;
        public string PostalCode { get; set; }=null !;

        public DateTime CreatedAt { get; set; }=DateTime.Now;
    }
}