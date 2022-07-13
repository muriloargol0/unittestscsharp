using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            var order = new Order();

            service.PlaceOrder(order);

            // To test the interaction between two objects, you can use the verify method of mock objects
            storage.Verify(s => s.Store(order));
        }
    }
}
