using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string SBIN { get; set; }
    }

    public static class BookContainer
    {
        public static List<Book> Books { get; set; } = new List<Book>() { new Book { Id = 1, Name = "Maths", Author = "Alex", SBIN = "1234" }, new Book { Id = 2, Name = "Social", Author = "Gray" } };
    }

}
