using Mvc5Project.Models;
using System;
using System.Collections.Generic;

namespace Mvc5Project.DAL
{
    public interface IBlogRepository : IDisposable
    {
        IList<Post> GetPosts();

        IList<Category> GetPostCategories();

        IList<Tag> GetPostTags();

        IList<PostVideo> GetPostVideos();

        int LikeDislikeCount(string typeAndlike, string id);
    }
}