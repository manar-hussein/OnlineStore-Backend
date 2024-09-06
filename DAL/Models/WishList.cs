using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class WishList
    {
        public int Id {  get; set; }
        public int UserId {  get; set; }
        public int ProductId {  get; set; }
    }
}
