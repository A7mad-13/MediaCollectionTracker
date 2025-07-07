using System;
using System.ComponentModel.DataAnnotations;

namespace MediaCollectionTracker.Models
{
    public class MediaItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Creator { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public string Genre { get; set; }

        public string Status { get; set; }

        public string MediaType { get; set; }
    }
}
