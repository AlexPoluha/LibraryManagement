using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Reflection.PortableExecutable;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        [ValidateNever]
        public Author Author { get; set; }
        public ICollection<Character> Characters { get; set; } = new List<Character>();

    }
}
