using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinApi.Providers.SmartRack
{
    public class SmartRackProvider : ISmartRackProvider
    {
        private SmartRackConfiguration smartRackConfiguration;

        public SmartRackProvider(SmartRackConfiguration configuration)
        { 
            this.smartRackConfiguration = configuration;
        }

        public async Task<int> ExampleMethod()
        {
            return await Task.FromResult(9876);
        }
    }
}
