namespace InventoryManagement.Models
{
	public class Inventory
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public decimal Amount { get; set; }
		public string? StoragePlace { get; set; }
	}
}
