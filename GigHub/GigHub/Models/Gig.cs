using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }


        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; } //introducting fk so that don't have to make roundtrip to the db so often.

        public DateTime DateTime { get; set; }


        [Required]
        [StringLength(255)]
        public string Venue { get; set; }


        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; } //same reason as 'ArtistId' above.
    }


}