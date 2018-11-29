using Mvc5Project.DAL;
using Mvc5Project.Models;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mvc5Project.Controllers
{
    public class BlogController : Controller
    {

        private IBlogRepository _blogRepository;
        public static List<BlogViewModel> postList = new List<BlogViewModel>(); //static list of posts to use in the view.
        public static List<AllPostsViewModel> allPostsList = new List<AllPostsViewModel>();
        public static List<AllPostsViewModel> checkCatList = new List<AllPostsViewModel>(); //Create lists for filtering based on category.
        public static List<AllPostsViewModel> checkTagList = new List<AllPostsViewModel>(); //Create lists for filtering based on tag.

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
        public ActionResult Index(int? page, string sortOrder, string searchString, string[] searchCategory, string[] searchTag)
        {
            checkCatList.Clear();
            checkTagList.Clear();
            CreateCatandTagList();

            Posts(page, sortOrder, searchString, searchCategory, searchTag);
            return View();
        }



        #region Posts/AllPosts

        [ChildActionOnly]
        public ActionResult Posts(int? page, string sortOrder, string searchString, string[] searchCategory, string[] searchTag) //Adds paging, filtering, and sorting
        {
            postList.Clear();

            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentSearchString = searchString;
            ViewBag.CurrentSearchCategory = searchCategory;
            ViewBag.CurrentSearchTag = searchTag;
            ViewBag.CurrentDateSortParm = string.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            ViewBag.TitleSortParm = sortOrder == "Title" ? "tile_desc" : "Title";

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




            //Get the posts that contain user's input
            if (searchString != null)
            {
                postList = postList.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();
            }

            if (searchCategory != null)
            {
                List<BlogViewModel> newlist = new List<BlogViewModel>();
                foreach (var catName in searchCategory)
                {
                    foreach (var item in postList)
                    {
                        if (item.PostCategories.Where(x => x.Name == catName).Any())
                        {
                            newlist.Add(item);
                        }
                    }
                    foreach (var item in checkCatList)
                    {
                        if (item.Category.Name == catName)
                        {
                            item.Checked = true;
                        }
                    }
                }
                postList = postList.Intersect(newlist).ToList(); //lookup 'intersect' later.
            }

            if (searchTag != null)
            {
                List<BlogViewModel> newlist = new List<BlogViewModel>();
                foreach (var tagName in searchTag)
                {
                    foreach (var item in postList)
                    {
                        if (item.PostTags.Where(x => x.Name == tagName).Any())
                        {
                            newlist.Add(item);
                        }
                    }
                    foreach (var item in checkTagList)
                    {
                        if (item.Tag.Name == tagName)
                        {
                            item.Checked = true;
                        }
                    }
                }
                postList = postList.Intersect(newlist).ToList();
            }

            switch (sortOrder) //lookup more about switch and case and break later.
            {
                case "date_desc":
                    postList = postList.OrderByDescending(x => x.PostedOn).ToList();
                    break;
                case "Title":
                    postList = postList.OrderBy(x => x.Title).ToList();
                    break;
                case "title_desc":
                    postList = postList.OrderByDescending(x => x.Title).ToList();
                    break;
                default:
                    postList = postList.OrderBy(x => x.PostedOn).ToList();
                    break;
            }


            //how many posts to display on a page.
            int pageSize = 2;
            int pageNumber = (page ?? 1);

            return PartialView("Posts", postList.ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        [AllowAnonymous]

        public ActionResult AllPosts(int? page, string sortOrder, string searchString, string[] searchCategory, string[] searchTag)
        {
            //clear the lists to prevent duplicates.
            allPostsList.Clear();
            checkCatList.Clear();
            checkTagList.Clear();

            //assign current filters to viewbags.
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentSearchString = searchString;
            ViewBag.CurrentSearchCategory = searchCategory;
            ViewBag.CurrentSearchTag = searchTag;
            ViewBag.DateSortParm = string.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            ViewBag.TitleSortParm = sortOrder == "Title" ? "title_desc" : "Title";

            //get all posts and for each of them create an AllPostsViewModel object and add it to the allPostsList.
            var posts = _blogRepository.GetPosts();
            foreach (var post in posts)
            {
                var postCategories = GetPostCategories(post);
                var postTags = GetPostTags(post);
                allPostsList.Add(new AllPostsViewModel()
                {
                    PostId = post.Id,
                    Date = post.PostedOn,
                    Description = post.ShortDescription,
                    Title = post.Title,
                    PostCategories = postCategories,
                    PostTags = postTags,
                    UrlSlug = post.UrlSeo
                });
            }

            if (searchString != null) //filter posts if there is a value in the search table.
            {
                allPostsList = allPostsList.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();
            }

            CreateCatandTagList(); //Create lists of categories and tags for filter.

            //if any category name is checked in the view, filter the posts.
            if (searchCategory != null)
            {
                List<AllPostsViewModel> newlist = new List<AllPostsViewModel>();
                foreach (var catName in searchCategory)
                {
                    foreach (var item in allPostsList)
                    {
                        if (item.PostCategories.Where(x => x.Name == catName).Any())
                        {
                            newlist.Add(item);
                        }
                    }
                    foreach (var item in checkCatList)
                    {
                        if (item.Category.Name == catName)
                        {
                            item.Checked = true;
                        }
                    }
                }
                allPostsList = allPostsList.Intersect(newlist).ToList();
            }

            //if any tag name is checked in the view, filter the posts.
            if (searchTag != null)
            {
                List<AllPostsViewModel> newlist = new List<AllPostsViewModel>();
                foreach (var TagName in searchTag)
                {
                    foreach (var item in allPostsList)
                    {
                        if (item.PostTags.Where(x => x.Name == tagName).Any())
                        {
                            newlist.Add(item);
                        }
                    }
                    foreach (var item in checkTagList)
                    {
                        if (item.Tag.Name == TagName)
                        {
                            item.Checked = true;
                        }
                    }
                }
                allPostsList = allPostsList.Intersect(newlist).ToList();
            }

            //sort the post list
            switch (sortOrder)
            {
                case "date_desc":
                    allPostsList = allPostsList.OrderByDescending(x => x.Date).ToList();
                    break;
                case "Title":
                    allPostsList = allPostsList.OrderBy(x => x.Title).ToList();
                    break;
                case "tile_desc":
                    allPostsList = allPostsList.OrderByDescending(x => x.Title).ToList();
                    break;
                default:
                    allPostsList = allPostsList.OrderBy(x => x.Date).ToList();
                    break;
            }

            //define how many posts you want to show on each page, and return to view with model.
            int pageSize = 2;
            int pageNumber = (page ?? 1);
            return View("AllPosts", allPostsList.ToPagedList(pageNumber, pageSize));
        }

        #endregion Posts/AllPosts


        #region Rss



        #endregion Rss


        //helper methods to call from view
        #region Helpers 
        public IList<Post> GetPosts()
        {
            return _blogRepository.GetPosts();
        }

        public IList<Category> GetPostCategories(Post post)
        {
            return _blogRepository.GetPostCategories(post);
        }

        public IList<Tag> GetPostTags(Post post)
        {
            return _blogRepository.GetPostTags(post);
        }

        public IList<PostVideo> GetPostVideos(Post post)
        {
            return _blogRepository.GetPostVideos(post);
        }

        public void CreateCatandTagList()
        {
            foreach (var ct in _blogRepository.GetCategories())
            {
                checkCatList.Add(new AllPostsViewModel { Category = ct, Checked = false });
            }
            foreach (var tg in _blogRepository.GetTags())
            {
                checkTagList.Add(new AllPostsViewModel { Tag = tg, Checked = false });
            }
        }
        #endregion
    }
}