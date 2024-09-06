using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateAndTime CreatedAt { get; set; }
    }
}
