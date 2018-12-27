using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    class ReplyLike
    {
        [Key]
        public string ReplyId { get; set; }

        public string Username { get; set; }

        public bool Like { get; set; }

        public bool Dislike { get; set; }

        public Reply Reply { get; set; }
    }
}
