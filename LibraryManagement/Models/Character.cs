using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LibraryManagement.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        public int BookId { get; set; }
        [ValidateNever]
        public Book Book { get; set; } 
    }
}