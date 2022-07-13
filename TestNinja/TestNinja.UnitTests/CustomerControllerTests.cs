using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var customer = new CustomerController();

            var result = customer.GetCustomer(0);

            // TypeOf enrusre that the result is exactly a NotFound object
            Assert.That(result, Is.TypeOf<NotFound>());

            // InstanceOf method means the result can be a NotFound object or
            // one of it's derivatives
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var customer = new CustomerController();

            var result = customer.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
