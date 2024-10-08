﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cart : BaseEntity
    {

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public  ICollection<CartItem>? CartItems { get; set; }
    }
}
