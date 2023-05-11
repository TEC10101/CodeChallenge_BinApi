using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinApi.Repositories.Item
{
    public class ItemRepository : IItemRepository
    {
        private ItemRepositoryConfiguration configuration;

        public ItemRepository(ItemRepositoryConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<bool> AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AdjustItem(Item item, int amount)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
