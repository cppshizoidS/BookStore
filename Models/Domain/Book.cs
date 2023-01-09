using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Domain;

public class Book
{
    public int Id { set; get; }
    [Required]
    public string Title { set; get; }
    
    [Required]
    public string ISBN { set; get; }

    [Required] 
    public int TotalPages { get; set; }
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public int PublisherId { get; set; }
    [Required]
    public int GenreId { get; set; }
}