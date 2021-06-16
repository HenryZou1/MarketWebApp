using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
       
        public string Name { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public Item() { }
    }
}
