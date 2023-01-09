using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Domain;

public class Author
{
    public int Id { set; get; }
    [Required] 
    public string AuthorName { set; get; }
}