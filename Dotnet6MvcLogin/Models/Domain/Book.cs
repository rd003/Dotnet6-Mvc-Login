using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet6MvcLogin.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int TotalPages { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public bool IsDeleted { get; set; }


        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }



    }
}
