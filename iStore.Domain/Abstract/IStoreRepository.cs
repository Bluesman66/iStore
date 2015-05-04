using System.Collections.Generic;
using iStore.Domain.Entities;

namespace iStore.Domain.Abstract
{
    public interface IStoreRepository
    {
        IEnumerable<Item> Items { get; } 
    }
}