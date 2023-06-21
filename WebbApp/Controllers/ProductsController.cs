using Microsoft.AspNetCore.Mvc;
using WebbApp.ViewModels;

namespace WebbApp.Controllers
{

    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ProductsIndexViewModel
            {
                All = new GridCollectionViewModel
                {
                    Title = "All Products",
                    Categories = new List<string> {"All", "Mobile", "Computers"}
                }
            };
            return View(viewModel);
        }

        public IActionResult Search()
        {
            ViewData["Title"] = "Search for products";
            return View();
        }
    }
}
