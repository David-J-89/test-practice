using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RefactorBlog.Models.Models
{
    public class Category
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "UrlSeo")]
        public string UrlSeo { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public bool Checked { get; set; }

        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
