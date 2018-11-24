using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList() //allowing the list of genres to be pulled from the database, to allow for the dropdownlist to work
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Gigs.Add(gig); //allows gig to be tracked by entity framework.
            _context.SaveChanges(); //at this point ef will generate a sql statement and execute it against the database.

            return RedirectToAction("Index", "Home"); //returns user to the homepage after creating a gig.

        }
    }
}