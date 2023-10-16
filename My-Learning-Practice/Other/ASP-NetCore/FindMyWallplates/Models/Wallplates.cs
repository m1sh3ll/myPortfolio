


using System.ComponentModel.DataAnnotations;

namespace FindMyWallplates.Models
{
  public class Wallplates
  {
    public int Id { get; set; }

    [Display (Name="Item SKU")]
    public string SKU { get; set; }

    [Display(Name = "Item Title")]
    public string Title { get; set; }


    public double Price { get; set; }

    [Display(Name = "In Stock")]
    public int Quantity { get; set; }



  }
}
