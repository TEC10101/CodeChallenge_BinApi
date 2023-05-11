using BinApi.Providers.SmartRack;
using BinApi.Repositories.Bin;
using BinApi.Repositories.Item;
using BinApi.Services.BinMaintenanceSvc;
using Moq;

namespace BinApi.UnitTests.ServiceTests
{
    [TestClass]
    public class BinMaintenanceSvcUnitTests
    {
        private Mock<ISmartRackProvider> _smartRackProviderMock;
        private Mock<IBinRepository> _binRepositoryMock;

        [TestInitialize]
        public void Initialize()
        {
            this._smartRackProviderMock = new Mock<ISmartRackProvider>();
            this._binRepositoryMock = new Mock<IBinRepository>();
        }

        [TestMethod]
        public async Task TestExampleMethod_HappyPath()
        {
            // Arrange
            var config = new SmartRackConfiguration()
            {
                Example = 0
            };

            // The default return example is 9876 so we set it up to mock and return 0 for this demo.
            this._smartRackProviderMock.Setup(m => m.ExampleMethod()).ReturnsAsync(config.Example);
            var service = new BinMaintenanceSvc(this._binRepositoryMock.Object, this._smartRackProviderMock.Object);


            // Act
            var result = await service.ExampleMethodForSmartRack();

            // Assert
            Assert.AreEqual(config.Example, result);
        }

        [TestMethod]
        public async Task AddBin_HappyPath()
        {
            // Arrange
            var config = new SmartRackConfiguration()
            {
                Example = 0
            };

            var testBin = new Bin()
            {
                Description = "Test Bin",
                Id = 1,
                Items = new List<Item>()
                {
                    new Item()
                    {
                        Id = 1,
                        Description = "Test Item",
                        Quantity = 1
                    }
                }
            };

            this._binRepositoryMock.Setup(m => m.AddBin(testBin)).ReturnsAsync(true);
            var service = new BinMaintenanceSvc(this._binRepositoryMock.Object, this._smartRackProviderMock.Object);

            // Act
            var result = await service.AddBin(testBin);

            // Assert
            Assert.IsTrue(result);
        }
    }
}