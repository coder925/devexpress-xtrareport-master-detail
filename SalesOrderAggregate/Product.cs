
using System.Collections.Generic;

public class Product
{
	public string Name { get; set; }

	public List<ProductSpecificationRow> ProductSpecifications { get; set; } = new List<ProductSpecificationRow>();
}

