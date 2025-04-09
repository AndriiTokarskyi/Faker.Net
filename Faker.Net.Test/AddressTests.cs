using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(name);
        }

        [TestMethod]
        public void GetCityNameTest()
        {
            Address address = new Address();
            var cityName = address.GetCityName();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(cityName);
        }

        [TestMethod]
        public void GetCityPrefixTest()
        {
            Address address = new Address();
            var cityPrefix = address.GetCityPrefix();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(cityPrefix);
        }
    }
}