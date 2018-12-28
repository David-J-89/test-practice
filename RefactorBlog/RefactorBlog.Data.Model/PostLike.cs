using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    class PostLike
    {
        [Key]
        public string PostId { get; set; }

        public string Username { get; set; }

        public bool Like { get; set; }

        public bool Dislike { get; set; }

        public Post Post { get; set; }
    }
}
