using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Domain;

public class Publisher
{
    public int Id { get; set; }
    [Required]
    public string PablisherName { get; set; }

    public string PublisherName { get; set; }
}