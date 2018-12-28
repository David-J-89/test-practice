using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    public class CommentLike
    {
        [Key]
        public string CommentId { get; set; }

        public string Username { get; set; }

        public bool Like { get; set; }

        public bool Dislike { get; set; }

        public Comment Comment { get; set; }
    }
}
