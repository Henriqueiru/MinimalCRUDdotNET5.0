using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDTesteComplete.ViewModels
{
  public class CreateTodoViewModel
  {
    [Required]
    public string Title { get; set; }
  }
}