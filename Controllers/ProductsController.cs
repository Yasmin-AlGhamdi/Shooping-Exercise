using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductModel> _Products = new List<ProductModel>()
        {
            new ProductModel{ ID = 1, Name = "T-Shirt", Price = 50.7m, Image = "https://www.rei.com/media/product/8814290006"},
            new ProductModel{ ID = 2, Name = "Dress", Price = 201.3m, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS5rFvqSUHTfZvbTkdpC8hcgr8gt2IQfNzeO8MyQjSqt6GsFa17B8cqf_W75Lmarn69PyW7hDFT&usqp=CAc"},
            new ProductModel{ ID = 3, Name = "Skirt", Price = 40.3m, Image = "https://media.istockphoto.com/photos/red-elegant-skirt-with-ribbon-bow-isolated-on-white-picture-id882157056?k=6&m=882157056&s=612x612&w=0&h=UD9iB1SIBldSnYKQtikLMAxEan0AuQj3US752FigGg0="},

        };
        public IActionResult Index(string color = "White")
        {

            ViewData["Products"] = _Products;
            ViewData["Color"] = color;
            return View();
        }
        public IActionResult Details(int? ID = 1, string color = "White")
        {
            ProductModel product = _Products.Find(b => b.ID == ID);
            if(product == null)
            {
                return Content("This product ID does not exist");
            }
            else
            {
                ViewData["Products"] = _Products.Find(b => b.ID == ID);
                ViewData["Color"] = color;
                return View();
            }
        }
    }
}
