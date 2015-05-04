using System.Collections.Generic;
using iStore.Domain.Abstract;
using iStore.Domain.Entities;

namespace iStore.Domain.Concrete
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _context = new StoreDbContext();

        public IList<Item> Items
        {
            get { return new List<Item>(_context.Items); }
        }
    }
}