using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
