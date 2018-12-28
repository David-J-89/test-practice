using OnlineShoppingStore.Domain.Abstract;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repo) //generate constructor first, then autogen the readonly field.
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}