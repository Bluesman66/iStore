using System.Collections.Generic;
using iStore.Domain.Entities;

namespace iStore.Domain.Abstract
{
    public interface IStoreRepository
    {
        IList<Item> Items { get; } 
    }
}