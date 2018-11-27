using Mvc5Project.DAL;
using Mvc5Project.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Mvc5Project.Controllers
{
    public class BlogController : Controller
    {

        private IBlogRepository _blogRepository;
        public static List<BlogViewModel> postList = new List<BlogViewModel>(); //static list of posts to use in the view

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

        [ChildActionOnly]
        public ActionResult Posts()
        {
            postList.Clear();

            var posts = _blogRepository.GetPosts();
            foreach (var post in posts)
            {
                var postCategories = GetPostCategories(post);
                var postTags = GetPostTags(post);
                var likes = _blogRepository.LikeDislikeCount("postlike", post.Id);
                var dislikes = _blogRepository.LikeDislikeCount("postdislike", post.Id);
                postList.Add(new BlogViewModel()
                {
                    Post = post,
                    Modified = post.Modified,
                    Title = post.Title,
                    ShortDescription = post.ShortDescription,
                    PostedOn = post.PostedOn,
                    ID = post.Id,
                    PostLikes = likes,
                    PostDislikes = dislikes,
                    PostCategories = postCategories,
                    PostTags = postTags,
                    UrlSlug = post.UrlSeo
                });
            }

            return PartialView("Posts");
        }


        //helper methods to call from view
        #region Helpers 
        public IList<Post> GetPosts()
        {
            return _blogRepository.GetPosts();
        }

        public IList<Category> GetPostCategories(Post post)
        {
            return _blogRepository.GetPostCategories();
        }

        public IList<Tag> GetPostTags(Post post)
        {
            return _blogRepository.GetPostTags();
        }

        public IList<PostVideo> GetPostVideos(Post post)
        {
            return _blogRepository.GetPostVideos();
        }
        #endregion
    }
}