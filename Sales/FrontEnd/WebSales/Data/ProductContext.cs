using WebSales.Models;

namespace WebSales.Data
{
	public static class ProductContext
	{
		public static readonly List<Product> Products = new List<Product>
		{

			new Product()
			{
				Name = "I Phone 14 Pro Max",
				Description = "This phone is the company's biggest change to its flagship",
				ImageFile = "product-1.png",
				Price = 950.00M,
				Category = "Smart Phopne"
			},
			new Product()
			{
				Name = "Samsung 7 Edge",
				Description = "This phone is the company's biggest change to its flagship",
				ImageFile = "product-2.png",
				Price = 840.00M,
				Category = "Smart Phopne"
			},
			new Product()
			{
				Name = "Xiomari",
				Description = "This phone is the company's biggest change to its flagship",
				ImageFile = "product-2.png",
				Price = 740.00M,
				Category = "Smart Phopne"
			}

		};
	}
}
