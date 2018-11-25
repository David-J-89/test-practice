using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mvc5Project.Models
{
    public class Post
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 5)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 20)]
        [Display(Name = "ShortDescription")]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 500)]
        [Display(Name = "Body")]
        public string Body { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 5)]
        [Display(Name = "Meta")]
        public string Meta { get; set; }

        [Required]
        [Display(Name = "UrlSeo")]
        public string UrlSeo { get; set; }

        public bool Published { get; set; }

        [DefaultValue(0)]
        public int NetLikeCount { get; set; }

        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Reply> Replies { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<PostVideo> PostVideos { get; set; }
        public ICollection<PostLike> PostLikes { get; set; }
    }
}