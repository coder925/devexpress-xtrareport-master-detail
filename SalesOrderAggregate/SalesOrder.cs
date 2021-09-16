using System.Collections.Generic;

public class SalesOrder
{
	public static readonly List<SalesOrder> SampleData = new List<SalesOrder>()
	{
		new SalesOrder
		{
			Number = 200101,
			Name = "Fashion week campaign",
			SalesOrderLines = new List<SalesOrderline>
			{
				new SalesOrderline { Description = "Coffee mug", Quantity = 5, Price = 200 },
				new SalesOrderline { Description = "T-shirt", Quantity = 15, Price = 107.50m },
				new SalesOrderline
				{
					Description = "Businss card",
					Quantity = 200,
					Price = 5000,
					Product = new Product()
					{
						Name = "Business card",
						ProductSpecifications = new List<ProductSpecificationRow>()
						{
							new ProductSpecificationRow() { Column1 = "Run:", Column2 = "", Column3 = "1000 copies"},
							new ProductSpecificationRow() { Column1 = "Format:", Column2 = "", Column3 = "A5"},
							new ProductSpecificationRow() { Column1 = "Pages:", Column2 = "", Column3 = "12 pages"},
						}
					}
				}
			}
		}
	};

	public int Number { get; set; }

	public string Name { get; set; }

	public List<SalesOrderline> SalesOrderLines { get; set; } = new List<SalesOrderline>();
}

