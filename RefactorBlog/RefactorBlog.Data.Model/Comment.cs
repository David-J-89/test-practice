using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    class Comment
    {
        public string Id { get; set; }

        public string PostId { get; set; }

        public DateTime DateTime { get; set; }

        public string Username { get; set; }

        [Required]
        public string Body { get; set; }

        [DefaultValue(0)]
        public int NetLikeCount { get; set; }

        [DefaultValue(false)]
        public bool Deleted { get; set; }

        public Post Post { get; set; }

        public ICollection<Reply> Replies { get; set; }

        public ICollection<CommentLike> CommentLikes { get; set; }
    }
}
