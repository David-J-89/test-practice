using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    public class Tag
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "UrlSeo")]
        public string UrlSeo { get; set; }

        public bool Checked { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
