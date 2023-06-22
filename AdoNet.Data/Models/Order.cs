namespace AdoNet.UI.Models;

public class Order
{
    public int Id { get; set; }
    public int OrderNumber { get; set; }
    public DateTime Orderdate { get; set; }
    public decimal Price { get; set; }
}