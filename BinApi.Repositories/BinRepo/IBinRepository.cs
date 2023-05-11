namespace BinApi.Repositories.Bin
{
    public interface IBinRepository
    {
        /// <summary>
        /// Add an item to a bin.
        /// </summary>
        /// <param name="bin">The bin we are modifying.</param>
        /// <param name="item">The item we are adding to the bin.</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> AddItemToBin(Bin bin, BinApi.Repositories.Item.Item item);

        /// <summary>
        /// Remove an item from a bin.
        /// </summary>
        /// <param name="bin">The Bin we are modifying.</param>
        /// <param name="item">The Item we are Removing</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> RemoveItemFromBin(Bin bin, BinApi.Repositories.Item.Item item);

        /// <summary>
        /// Adjust the item quantity in a bin.
        /// </summary>
        /// <param name="bin">The Bin we are modifying</param>
        /// <param name="item">The Item we are modifying</param>
        /// <param name="quantity">The new quantity we are updating to.</param>
        /// <returns>Success/Fail</returns>
        public Task<bool> AdjustItemQuantity(Bin bin, BinApi.Repositories.Item.Item item, int quantity);

        /// <summary>
        /// Add a Bin to the database.
        /// </summary>
        /// <param name="bin">The Bin we are adding.</param>
        /// <returns>Success/Fail.  Perhaps bin details, i.e Id.</returns>
        public Task<bool> AddBin(Bin bin);
    }
}
