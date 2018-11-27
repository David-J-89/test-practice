﻿using Mvc5Project.Models;
using System;
using System.Collections.Generic;

namespace Mvc5Project.DAL
{
    public interface IBlogRepository : IDisposable
    {
        IList<Post> GetPosts();

        IList<Category> GetPostCategories(Post post);

        IList<Tag> GetPostTags(Post post);

        IList<PostVideo> GetPostVideos(Post post);

        int LikeDislikeCount(string typeAndlike, string id);

    }
}