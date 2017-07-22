using System;
using System.ComponentModel.DataAnnotations;

namespace codesnippet.Models
{
  public class Snippet
  {
    public int ID { get; private set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(140, ErrorMessage = "Must be under 140 characters")]
    public string Title { get; set; }

    [StringLength(140, ErrorMessage = "Must be under 140 characters")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Code Snippet is required")]
    [Display(Name = "Code Snippet")]
    public string CodeSnippet { get; set; }

    [Required(ErrorMessage = "Language is required")]
    [StringLength(60, ErrorMessage = "Must be under 60 characters")]
    [Display(Name = "Code Language")]
    public string Language { get; set; }
  }
}

