using System;

namespace Faker.Tests
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TestClassAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodAttribute : Attribute { }

    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void GetStreetNameTest()
        {
            Address address = new Address();
            var name = address.GetStreetName();
            Console.WriteLine($"Street name: {name}");
        }

        [TestMethod]
        public void GetCityNameTest()
        {
            Address address = new Address();
            var name = address.GetCityName();
            Console.WriteLine($"City name: {name}");
        }

        [TestMethod]
        public void GetCityPrefixTest()
        {
            Address address = new Address();
            var prefix = address.GetCityPrefix();
            Console.WriteLine($"City prefix: {prefix}");
        }
    }
}