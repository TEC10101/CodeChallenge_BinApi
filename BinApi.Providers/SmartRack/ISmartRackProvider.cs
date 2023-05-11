using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinApi.Providers.SmartRack
{
    public interface ISmartRackProvider
    {
        public Task<int> ExampleMethod();
    }
}
