using Faker.Locales;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using MSTest = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Net.Test.LocaleTest
{
    [MSTest.TestClass]
    public class LocaleFactoryTest
    {
        [MSTest.TestMethod]
        public void TestCreate()
        {
            Type localeFactoryType = typeof(En).Assembly.GetType("Faker.LocaleFactory");
            MethodInfo createMethod = localeFactoryType.GetMethod("Create", BindingFlags.Public | BindingFlags.Static);
            object result = createMethod.Invoke(null, new object[] { LocaleType.en });
            MSTest.Assert.AreEqual(typeof(En), result.GetType());
        }
    }
}