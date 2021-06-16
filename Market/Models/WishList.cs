using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class WishList
    {
       
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }

        public WishList()
        {
       
        }
    }
}
