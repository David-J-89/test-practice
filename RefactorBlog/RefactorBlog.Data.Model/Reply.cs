using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    public class Reply
    {
        public string Id { get; set; }

        public string PostId { get; set; }

        public string CommentId { get; set; }

        public string ParentReplyId { get; set; }

        public DateTime DateTime { get; set; }

        public string Username { get; set; }

        [Required]
        public string Body { get; set; }

        [DefaultValue(false)]
        public bool Deleted { get; set; }

        public Post Post { get; set; }

        public Comment Comment { get; set; }

        public ICollection<ReplyLike> ReplyLikes { get; set; }
    }
}
