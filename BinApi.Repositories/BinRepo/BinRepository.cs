namespace BinApi.Repositories.Bin
{
    public class BinRepository : IBinRepository
    {
        private BinRepositoryConfiguration configuration;

        public BinRepository(BinRepositoryConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <inheritdoc/>
        public async Task<bool> AddBin(Bin bin)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<bool> AddItemToBin(Bin bin, BinApi.Repositories.Item.Item item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<bool> AdjustItemQuantity(Bin bin, Item.Item item, int quantity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<bool> RemoveItemFromBin(Bin bin, Item.Item item)
        {
            throw new NotImplementedException();
        }
    }
}