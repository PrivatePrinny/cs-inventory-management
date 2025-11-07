using InventoryManagement.Models;

namespace InventoryManagement.Data
{
	public static class DBInitializer
	{
		public static void Initialize(InventoryContext context)
		{
			context.Database.EnsureCreated();

			if (context.Inventories.Any())
			{
				return; // DB has been seeded
			}
			var inventories = new[]
			{
				new Inventory { Name = "Item1", Amount = 10, StoragePlace = "Shelf1" },
				new Inventory { Name = "Item2", Amount = 20, StoragePlace = "Shelf2" },
				new Inventory { Name = "Item3", Amount = 30, StoragePlace = "Shelf3" }
			};
			context.Inventories.AddRange(inventories);
			context.SaveChanges();
		}
	}
}
