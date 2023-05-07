using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteBanDTOnline.Models
{
    public class Wishlist
    {
        public List<WishlistItem> Items { get; set; }
        public Wishlist()
        {
            this.Items = new List<WishlistItem>();
        }
        public void AddToWishList(WishlistItem item)
        {
            var checkExits = Items.FirstOrDefault(x => x.ProductId == item.ProductId);
            if (checkExits != null)
            {
                
            }
            else
            {
                Items.Add(item);
            }
        }
        public void Remove(int id)
        {
            var checkExits = Items.SingleOrDefault(x => x.ProductId == id);
            if (checkExits != null)
            {
                Items.Remove(checkExits);
            }
        }
        public void ClearWishList()
        {
            Items.Clear();
        }
    }
    public class WishlistItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Alias { get; set; }
        public int CategoryName { get; set; }
        public string ProductImg { get; set; }
        public decimal Price { get; set; }

    }
}
