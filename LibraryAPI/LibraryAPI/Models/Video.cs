using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Video : LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
