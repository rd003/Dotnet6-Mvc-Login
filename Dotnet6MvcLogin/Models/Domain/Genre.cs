using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet6MvcLogin.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string GenreName { get; set; }
        public bool IsDeleted { get; set; }


        public virtual List<Book> Books { get; set; }
    }
}
