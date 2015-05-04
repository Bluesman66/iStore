using System.Collections.Generic;
using iStore.Domain.Entities;

namespace iStore.WebUI.Models
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public PagingInfo PagingInfo { get; set; } 
    }
}