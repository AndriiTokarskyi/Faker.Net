using Microsoft.VisualStudio.TestTools.MSTest;

namespace Faker.Tests
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void GetStreetNameTest()
        {
            Address address = new Address();
            var name = address.GetStreetName();

        }

        [TestMethod]
        public void GetCityNameTest()
        {

        }

        [TestMethod]
        public void GetCityPrefixTest()
        {

        }
    }
}