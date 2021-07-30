using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SSDeShopOnWeb.Data;
using SSDeShopOnWeb.Models;

namespace SSDeShopOnWeb.Pages
{
    public class IndexModel : PageModel
    {
        protected readonly StoreDbContext db;
        public IndexModel(StoreDbContext dbContext)
        {
            db = dbContext;
        }
        public List<Product> Products { get; set; } = new List<Product>();


        public void OnGet()
        
        {
        //    Products = new List<Product>()
        //    {
        //        new Product(".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", "/images/products/1.png", 19.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/2.png",8.5m),
        //        new Product("Prism White T-Shirt", ".NET Black & White Mug", "/images/products/3.png",8.5m),
        //        new Product(".NET Foundation Sweatshirt", ".NET Black & White Mug", "/images/products/4.png",8.5m),
        //        new Product("Roslyn Red Sheet", ".NET Black & White Mug", "/images/products/5.png",8.5m),
        //        new Product(".NET Blue SweatShirt", ".NET Black & White Mug", "/images/products/6.png",8.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/7.png",8.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/8.png",8.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/9.png",8.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/10.png",8.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/11.png",8.5m),
        //        new Product(".NET Black & White Mug", ".NET Black & White Mug", "/images/products/12.png",8.5m)
        //    };
        Products=db.Products.ToList();
        }

        
    }
}
