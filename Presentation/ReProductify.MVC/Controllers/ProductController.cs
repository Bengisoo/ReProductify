using Microsoft.AspNetCore.Mvc;
using ReProductify.Domain.Entities;
using ReProductify.Persistence.Contexts;

namespace ReProductify.MVC.Controllers
{
	public class ProductController : Controller
	{

		ReProductifyDbContext _context;

		public ProductController()
		{
			_context = new();
		}
		public IActionResult GetAll()
		{
			return View(_context.Products.ToList());
		}
		[HttpGet]
		public IActionResult AddProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddProduct(string productName)
		{
			_context.Products.Add(new(productName));

			_context.SaveChanges();

			return View();
		}

		[HttpGet]
		public IActionResult Remove()
		{
			return View(_context.Products.ToList());
		}

		[HttpPost]
		public IActionResult Remove(List<Guid> selectedProducts)
		{
			if (selectedProducts != null && selectedProducts.Any())
			{
				foreach (var productId in selectedProducts)
				{
					var productToRemove = _context.Products.Find(productId);
					if (productToRemove != null)
					{
						_context.Products.Remove(productToRemove);
					}
				}
				_context.SaveChanges();
			}

			return RedirectToAction("GetAll", "Product");
		}
	}
}
