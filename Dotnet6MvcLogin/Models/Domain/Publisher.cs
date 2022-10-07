using Microsoft.Build.Framework;

namespace Dotnet6MvcLogin.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
