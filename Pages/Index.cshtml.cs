using Bakery.Data;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryContext db;
        public IndexModel(BakeryContext db) => this.db = db;

        public List<Product> Products { get; set; } = new List<Product>();
        public Product FeaturedProduct { get; set; }
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            if (Products.Count > 0)
            {
                int randomIndex = new Random().Next(Products.Count);
                FeaturedProduct = Products.ElementAt(randomIndex);
            }
            else
            {
                // Handle case when Products is empty
                RedirectToPage();

            }
            //FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}   