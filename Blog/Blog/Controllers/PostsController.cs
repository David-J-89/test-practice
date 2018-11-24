using Blog.Models;
using System;
using System.Linq;
using System.Web.Mvc;
//using System.Collections.ObjectModel;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        private BlogModel model = new BlogModel();
        // GET: Posts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update(int? id, string title, string body, DateTime dateTime, string tags)
        {
            if (!IsAdmin)
            {
                return RedirectToAction("Index");
            }

            Post post = GetPost(id);
            post.Title = title;
            post.Body = body;
            post.DateTime = dateTime;
            post.Tag.Clear();

            tags = tags ?? string.Empty;
            string[] tagNames = tags.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string tagName in tagNames)
            {
                post.Tag.Add(GetTag(tagName));
            }

            if (!id.HasValue)
            {
                model.AddToPosts(post);
            }
            model.SaveChanges();
            return RedirectToAction("Details", new { id = post.ID });
        }

        private Tag GetTag(string tagName)
        {
            return model.Tags.Where(x => x.Name == tagName).FirstOrDefault() ?? new Tag() { Name = tagName };
        }
        private Post GetPost(int? id)
        {
            return id.HasValue ? model.Posts.Where(x => x.ID == id).First() : new Post() { ID = -1 };
        }
        //TODO: don't just return true.
        public bool IsAdmin { get { return true; } } //Session["IsAdmin"] != null && (bool)Session["IsAdmin"]; } }
    }
}