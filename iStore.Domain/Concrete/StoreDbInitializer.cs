using iStore.Domain.Entities;
using System.Data.Entity;

namespace iStore.Domain.Concrete
{
	public class StoreDbInitializer : DropCreateDatabaseAlways<StoreDbContext>
	{
		protected override void Seed(StoreDbContext context)
		{
			context.Items.Add(new Item { ItemId = 1, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 2, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 3, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 4, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 5, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 6, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 7, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 8, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 9, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 10, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 11, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 12, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 13, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 14, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 15, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 16, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 17, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 18, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 19, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 20, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			context.Items.Add(new Item { ItemId = 21, Name = "Маечка", Description = "Маечка", Category = "Одежда", Price = 300.00M, ImageData = null, ImageMimeType = null });
			
			base.Seed(context);
		}
	}
}
