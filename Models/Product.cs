using System.ComponentModel.DataAnnotations;

public class Product
{
    [Required(ErrorMessage = "Necessary")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Necessary")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Necessary")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be > 0")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Necessary")]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity coudn`t be negative")]
    public int StockQuantity { get; set; }
}
