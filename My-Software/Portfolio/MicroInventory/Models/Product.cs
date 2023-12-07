using System.ComponentModel.DataAnnotations;

namespace MyInventory.Models
{
  public class Product
  {
    public int Id { get; set; }  
    
    public string Title { get; set; }

    public decimal Price { get; set; }

    public string ImageURL { get; set; }

    public string Description { get; set; }
  }
}
