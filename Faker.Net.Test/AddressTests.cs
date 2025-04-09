using System;

namespace Faker.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class AddressTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void GetStreetNameTest()
        {
            Address address = new Address();
            var name = address.GetStreetName();

        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void GetCityNameTest()
        {

        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void GetCityPrefixTest()
        {

        }
    }
}