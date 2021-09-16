using System.Collections.Generic;

public class SalesOrder
{
	public int Number { get; set; }

	public string Name { get; set; }

	public List<SalesOrderline> SalesOrderLines { get; set; } = new List<SalesOrderline>();
}

