using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatTest.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return Redirect("/");
            }

            var currentUser = (Models.User)Session["user"];

            using (var db = new Models.ChatContext())
            {
                ViewBag.allUsers = db.Users.Where(u => u.name != currentUser.name)
                    .ToList();
            }

            ViewBag.currentUser = currentUser;

            return View();
        }
    }
}