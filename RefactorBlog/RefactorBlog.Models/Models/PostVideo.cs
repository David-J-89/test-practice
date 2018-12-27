using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    class PostVideo
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "VideoUrl")]
        [DataType(DataType.Url)]
        public string VideoUrl { get; set; }

        public string VideoThumbnail { get; set; }

        public string PostId { get; set; }

        public string VideoSiteName { get; set; }

        public Post Post { get; set; }
    }
}
