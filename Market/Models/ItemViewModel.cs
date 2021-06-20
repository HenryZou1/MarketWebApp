using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class ItemsViewModel : Item
    {
        public int WishListId { get; set; }
        public ItemsViewModel(Item Element, int WishListId)
        {
            Id = Element.Id;
            Name = Element.Name;
            Price = Element.Price;
            Type = Element.Type;
            Date = Element.Date;
            Description = Element.Description;
            this.WishListId = WishListId;
        }
    }
}
