
public class SalesOrderline
{
	public string Description { get; set; }

	public int Quantity { get; set; }

	public decimal Price { get; set; }

	public Product Product { get; set; } = new Product();
}

