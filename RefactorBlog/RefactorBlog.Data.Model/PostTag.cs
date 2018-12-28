using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefactorBlog.Models.Models
{
    class PostTag
    {
        [Key]
        [Column(Order = 0)]
        public string PostId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string TagId { get; set; }

        public bool Checked { get; set; }

        public Post Post { get; set; }

        public Tag Tag { get; set; }
    }
}
