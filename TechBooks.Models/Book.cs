using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TechBooks.Models;

public class Book
{
    [Key]
    [DisplayName("Book Id")]
    public int BookId { get; set; }

    [Required]
    [DisplayName("Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; } = new Category();

    [Required]
    [StringLength(50)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public DateTime CreationDate { get; set; }

    public List<Author> Authors { get; set; } = new List<Author>();
}