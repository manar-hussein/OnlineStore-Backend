﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId{ get; set; }
        public int Quantity{ get; set; }
        public DateAndTime CreatedAt { get; set; }
    }
}
