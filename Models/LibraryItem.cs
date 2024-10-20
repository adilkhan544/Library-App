using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_App.Models
{
    public class LibraryItem
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string BookTitle { get; set; }
      

        public string BookAuther { get; set; }
        [Required]
        public string? Content { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

		public string? Description { get; set; }
    }
}
