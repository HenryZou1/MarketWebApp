using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Market.Data;
using Market.Models;

namespace Market.Controllers
{
    public class WishListsController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public WishListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WishLists
        public async Task<IActionResult> Index()
        {
            List<WishList> wishList = await _context.WishList.ToListAsync();
            List<ItemsViewModel> cartList = new List<ItemsViewModel>();
            foreach (WishList element in wishList) {
                if (element.UserId == 1) {
                    var item = await _context.Item.FirstOrDefaultAsync(m => m.Id == element.ItemId);
                    cartList.Add(new ItemsViewModel(item, element.Id));
                }
            }
            return View( cartList);
        }

        // GET: WishLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishList = await _context.WishList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wishList == null)
            {
                return NotFound();
            }

           
            _context.WishList.Remove(wishList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool WishListExists(int id)
        {
            return _context.WishList.Any(e => e.Id == id);
        }
    }
}
