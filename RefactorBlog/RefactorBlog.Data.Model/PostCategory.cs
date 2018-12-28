using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefactorBlog.Models.Models
{
    class PostCategory
    {
        [Key]
        [Column(Order = 0)] //lookup what this does.
        public string PostId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string CategoryId { get; set; }

        public bool Checked { get; set; }

        public Post Post { get; set; }

        public Category Category { get; set; }

    }
}
