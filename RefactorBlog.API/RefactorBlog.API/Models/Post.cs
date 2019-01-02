namespace RefactorBlog.API.Models
{
    public class Post
    {
        public string Id { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 5)]
        //[Display(Name = "Title")]
        public string Title { get; set; }

        //[Required]
        //[StringLength(250, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 20)]
        //[Display(Name = "ShortDescription")]
        public string ShortDescription { get; set; }

        //[Required]
        //[StringLength(5000, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 500)]
        //[Display(Name = "Body")]
        public string Body { get; set; }

        //[Required]
        //[StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 5)]
        //[Display(Name = "Meta")]
        public string Meta { get; set; }

    }
}
