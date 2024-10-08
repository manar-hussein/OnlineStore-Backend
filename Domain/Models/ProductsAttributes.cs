﻿//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductsAttributes : BaseEntity
    { 

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }

        public ProductsAttributeType Type {  get; set; }
        public string Value { get; set; } = null!;
    }
}
