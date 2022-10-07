using System.ComponentModel.DataAnnotations;

namespace Dotnet6MvcLogin.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        public string? AuthorMiddleName { get; set; }
        [Required]
        public string  AuthorLastName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual List<Book> Books { get; set; }

    }
}
