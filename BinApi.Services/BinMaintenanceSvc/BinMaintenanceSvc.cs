using BinApi.Providers.SmartRack;
using BinApi.Repositories.Bin;

namespace BinApi.Services.BinMaintenanceSvc
{
    public class BinMaintenanceSvc : IBinMaintenanceSvc
    {
        private IBinRepository binRepository { get; set; }
        private ISmartRackProvider smartRackProvider { get; set; }

        public BinMaintenanceSvc(IBinRepository binRepository, ISmartRackProvider smartRackProvider)
        {
            this.binRepository = binRepository;
            this.smartRackProvider = smartRackProvider;
        }

        public async Task<bool> AddBin(Bin bin)
        {
            // Logic to validate bin.

            return await this.binRepository.AddBin(bin);
        }

        /// <summary>
        /// Example method if we need to call the SmartRackProvider.
        /// </summary>
        /// <returns>int</returns>
        public async Task<int> ExampleMethodForSmartRack()
        {
            return await this.smartRackProvider.ExampleMethod();
        }
    }
}