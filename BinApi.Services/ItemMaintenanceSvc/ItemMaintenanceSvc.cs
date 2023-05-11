using BinApi.Repositories.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinApi.Services.ItemMaintenanceSvc
{
    public class ItemMaintenanceSvc : IItemMaintenanceSvc
    {
        private IItemRepository repository { get; set; }
        
        public ItemMaintenanceSvc(IItemRepository itemRepository)
        {
            this.repository = itemRepository;
        }

        public Task<Item> AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AdjustItem(Item item, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
