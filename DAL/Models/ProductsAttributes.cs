using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class ProductsAttributes
    { 
        public int Id {  get; set; }
        public ProductsAttributeType Type {  get; set; }
        public string Value { get; set; } //int?
    }
}
