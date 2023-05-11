namespace BinApi.Repositories.Item
{
    public interface IItemRepository
    {
        /// <summary>
        /// Add an item to the database.
        /// </summary>
        /// <param name="item">The item we are adding to the database.</param>
        /// <returns>Success/Fail. Could return Item Details such as new Id.</returns>
        public Task<bool> AddItem(Item item);

        /// <summary>
        /// Adjust an item's quantity in the database.
        /// </summary>
        /// <param name="item">The item we are modifying.</param>
        /// <param name="amount">The new amount we are updating to.</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> AdjustItem(Item item, int amount);

        /// <summary>
        /// Delete an item from the database.
        /// </summary>
        /// <param name="item">The item we are deleting.</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> RemoveItem(Item item);
    }
}
