using System.Collections.Generic;
using iStore.Domain.Abstract;
using iStore.Domain.Entities;

namespace iStore.Domain.Concrete
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _context = new StoreDbContext();

        public IEnumerable<Item> Items
        {
            get { return _context.Items; }
        }
    }
}