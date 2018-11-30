using Mvc5Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mvc5Project.DAL
{
    public class BlogRepository : IBlogRepository, IDisposable
    {
        private BlogDbContext _context;

        public BlogRepository(BlogDbContext context)
        {
            _context = context;
        }





        public int LikeDislikeCount(string typeAndlike, string id)
        {
            switch (typeAndlike)
            {
                case "postlike":
                    return _context.PostLikes.Where(p => p.PostId == id && p.Like == true).Count();
                case "postdislike":
                    return _context.PostLikes.Where(p => p.PostId == id && p.Dislike == true).Count();
                case "commentlike":
                    return _context.CommentLikes.Where(p => p.CommentId == id && p.Like == true).Count();
                case "commentdislike":
                    return _context.CommentLikes.Where(p => p.CommentId == id && p.Dislike == true).Count();
                case "replylike":
                    return _context.ReplyLikes.Where(p => p.ReplyId == id && p.Like == true).Count();
                case "replydislike":
                    return _context.ReplyLikes.Where(p => p.ReplyId == id && p.Dislike == true).Count();
                default:
                    return 0;
            }
        }



        public IList<Post> GetPosts()
        {
            return _context.Posts.ToList();
        }

        public IList<Category> GetPostCategories(Post post)
        {
            var categoryIds = _context.PostCategories.Where(p => p.PostId == post.Id).Select(p => p.CategoryId).ToList();
            List<Category> categories = new List<Category>();
            foreach (var catId in categoryIds)
            {
                categories.Add(_context.Categories.Where(p => p.Id == catId).FirstOrDefault());
            }
            return categories;
        }

        public IList<Tag> GetPostTags(Post post)
        {
            var tagIds = _context.PostTags.Where(p => p.PostId == post.Id).Select(p => p.TagId).ToList();
            List<Tag> tags = new List<Tag>();
            foreach (var tagId in tagIds)
            {
                tags.Add(_context.Tags.Where(p => p.Id == tagId).FirstOrDefault());
            }
            return tags;
        }

        public IList<PostVideo> GetPostVideos(Post post)
        {
            var postUrls = _context.PostVideos.Where(p => p.PostId == post.Id).ToList();
            List<PostVideo> videos = new List<PostVideo>();
            foreach (var url in postUrls)
            {
                videos.Add(url);
            }
            return videos;
        }

        public IList<Tag> GetTags()
        {
            return _context.Tags.ToList();
        }

        public IList<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }


        //for SEO we'll use slugs and we use them to get post ids when necessary
        public Post GetPostById(string id)
        {
            return _context.Posts.Find(id);
        }

        public string GetPostIdBySlug(string slug)
        {
            return _context.Posts.Where(x => x.UrlSeo == slug).FirstOrDefault().Id;
        }


        //check the postlike table to see if user has voted/liked the post.
        public void UpdatePostLike(string postid, string username, string likeordislike)
        {
            var postLike = _context.PostLikes.Where(x => x.Username == username && x.PostId == postid).FirstOrDefault();
            if (postLike != null)
            {
                switch (likeordislike)
                {
                    case "like":
                        if (postLike.Like == false) { postLike.Like = true; postLike.Dislike = false; }
                        else postLike.Like = false;
                        break;
                    case "dislike":
                        if (postLike.Dislike == false) { postLike.Dislike = true; postLike.Like = false; }
                        else postLike.Dislike = false;
                        break;
                }
                if (postLike.Like == false && postLike.Dislike == false) _context.PostLikes.Remove(postLike);
            }
            else
            {
                switch (likeordislike)
                {
                    case "like":
                        postLike = new PostLike() { PostId = postid, Username = username, Like = true, Dislike = false };
                        _context.PostLikes.Add(postLike);
                        break;
                    case "dislike":
                        postLike = new PostLike() { PostId = postid, Username = username, Like = false, Dislike = true };
                        _context.PostLikes.Add(postLike);
                        break;
                }
            }
            var post = _context.Posts.Where(x => x.Id == postid).FirstOrDefault();
            post.NetLikeCount = LikeDislikeCount("postlike", postid) - LikeDislikeCount("postdislike", postid);
            Save();
        }



        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}