using System.Data.Entity;
using iStore.Domain.Entities;

namespace iStore.Domain.Concrete
{
    public class StoreDbContext : DbContext
    {
		public DbSet<Item> Items { get; set; }
    }
}