using System.ComponentModel.DataAnnotations;

namespace Book_Management_System.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Pages { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
