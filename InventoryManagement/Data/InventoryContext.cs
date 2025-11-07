using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Data
{
	public class InventoryContext : DbContext
	{
		public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
		{
		}

		public DbSet<Inventory> Inventories { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Inventory>(entity =>
			{
				entity.ToTable("Inventories"); // Correct usage of ToTable
				entity.HasKey(i => i.Id);
				entity.Property(i => i.Name).IsRequired();
				entity.Property(i => i.Amount).IsRequired();
				entity.Property(i => i.StoragePlace).IsRequired();
			});
		}
	}
}
