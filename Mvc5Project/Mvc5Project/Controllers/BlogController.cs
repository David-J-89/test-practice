using Mvc5Project.DAL;
using Mvc5Project.Models;
using System.Web.Mvc;

namespace Mvc5Project.Controllers
{
    public class BlogController : Controller
    {

        private IBlogRepository _blogRepository;

        public BlogController()
        {
            _blogRepository = new BlogRepository(new BlogDbContext());
        }

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}