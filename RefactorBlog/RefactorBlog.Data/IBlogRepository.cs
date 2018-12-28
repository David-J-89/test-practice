using RefactorBlog.Models.Models;
using System;
using System.Collections.Generic;

namespace RefactorBlog.Data
{
    public interface IBlogRepository : IDisposable
    {
        IList<Post> GetPosts();

        IList<Category> GetPostCategories(Post post);

        IList<Tag> GetPostTags(Post post);

        IList<PostVideo> GetPostVideos(Post post);

        int LikeDislikeCount(string typeAndlike, string id);


        IList<Tag> GetTags();

        IList<Category> GetCategories();


        //add method definitions to the interface for the seo slugs in blogrepo.
        Post GetPostById(string postid);
        string GetPostIdBySlug(string slug);



        void UpdatePostLike(string postid, string username, string likeordislike);
        void AddVideoToPost(string postid, string videoUrl);
        void RemoveVideoFromPost(string postid, string videoUrl);

        void AddPostCategories(PostCategory postCategory);
        void RemovePostCategories(string postid, string categoryid);
        void RemoveCategoryFromPost(string postid, string catName);
        void AddNewCategory(string catName, string catUrlSeo, string catDesc);


        void Save();
    }
}
