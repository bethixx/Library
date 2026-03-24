namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
