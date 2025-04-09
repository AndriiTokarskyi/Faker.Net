using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void GetCityNameTest()
        {
            Address address = new Address();
            var cityName = address.GetCityName();
            Assert.IsNotNull(cityName);
        }

        [TestMethod]
        public void GetCityPrefixTest()
        {
            Address address = new Address();
            var cityPrefix = address.GetCityPrefix();
            Assert.IsNotNull(cityPrefix);
        }
    }
}