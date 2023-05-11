using BinApi.Repositories.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinApi.Services.ItemMaintenanceSvc
{
    public interface IItemMaintenanceSvc
    {
        /// <summary>
        /// Business logic encapsulating the addition of an item to the database.
        /// </summary>
        /// <param name="item">We assume we need an item to do this.</param>
        /// <returns>Completed Item Details</returns>
        public Task<Item> AddItem(Item item);

        /// <summary>
        /// Adjust the given item's quantity in the database.
        /// </summary>
        /// <param name="item">The item we are adjusting.</param>
        /// <param name="quantity">The new quantity we are updating the item to.</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> AdjustItem(Item item, int quantity);

        /// <summary>
        /// Delete the given item from the database.
        /// </summary>
        /// <param name="item">The item Id for that which we are deleting.</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> RemoveItem(int id);
    }
}
