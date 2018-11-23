using GigHub.Models;
using GigHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController() //initialize _context with a constructor
        {
            _context = new ApplicationDbContext();
        }

        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList() //allowing the list of genres to be pulled from the database, to allow for the dropdownlist to work
            };
            return View(viewModel);
        }
    }
}