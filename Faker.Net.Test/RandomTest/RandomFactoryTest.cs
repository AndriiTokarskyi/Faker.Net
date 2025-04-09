using System;
using System.Collections.Generic;
using System.Reflection;
using Faker.Locales;
using Faker.Random;

namespace Faker.Net.Test.RandomTest
{
    [TestClass]
    public class RandomFactoryTest
    {
        [TestMethod]
        public void TestRandomSelection()
        {
            int i = RandomProxy.Next();
            DummyClass d = new DummyClass(i);

            // Use reflection to create an instance of RandomFactory
            Type randomFactoryType = typeof(RandomProxy).Assembly.GetType("Faker.Random.RandomFactory");
            object r = Activator.CreateInstance(randomFactoryType, d, LocaleType.en);

            // Use reflection to call GetRandomItemFromProperty
            MethodInfo getRandomItemMethod = randomFactoryType.GetMethod("GetRandomItemFromProperty");
            var result = (int)getRandomItemMethod.Invoke(r, new object[] { "Test1", d });

            System.Diagnostics.Debug.Assert(Array.Exists(d.Test1, n => n == result));
        }

        [TestMethod]
        public void TestRandomFillin()
        {
            int m = RandomProxy.Next();
            DummyClass d = new DummyClass(m);
            string format = @"#{Test1} #{Test2}";

            // Use reflection to create an instance of RandomFactory
            Type randomFactoryType = typeof(RandomProxy).Assembly.GetType("Faker.Random.RandomFactory");
            object r = Activator.CreateInstance(randomFactoryType, d, LocaleType.en);

            // Use reflection to call FillInRandomData method
            MethodInfo fillInRandomDataMethod = randomFactoryType.GetMethod("FillInRandomData", new[] { typeof(string), typeof(object) });

            for (int i = 0; i < 100000; i++)
            {
                var result = (string)fillInRandomDataMethod.Invoke(r, new object[] { format, d });
                string[] numbers = result.Split(' ');
                System.Diagnostics.Debug.Assert(numbers.Length == 2);
                System.Diagnostics.Debug.Assert(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
                System.Diagnostics.Debug.Assert(Array.Exists(d.Test2, n => n == int.Parse(numbers[1])));
            }
        }

        [TestMethod]
        public void TestNextMethod1()
        {
            int m = RandomProxy.Next();
            DummyClass d = new DummyClass(m);
            string format = @"#{Test1} #{Test2}";

            // Use reflection to create an instance of RandomFactory
            Type randomFactoryType = typeof(RandomProxy).Assembly.GetType("Faker.Random.RandomFactory");
            object r = Activator.CreateInstance(randomFactoryType, d, LocaleType.en);

            // Use reflection to call Next method
            MethodInfo nextMethod = randomFactoryType.GetMethod("Next", new[] { typeof(string) });

            for (int i = 0; i < 100000; i++)
            {
                var result = (string)nextMethod.Invoke(r, new object[] { format });
                string[] numbers = result.Split(' ');
                System.Diagnostics.Debug.Assert(numbers.Length == 2);
                System.Diagnostics.Debug.Assert(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
                System.Diagnostics.Debug.Assert(Array.Exists(d.Test2, n => n == int.Parse(numbers[1])));
            }
        }

        [TestMethod]
        public void TestNextMethod2()
        {
            int m = RandomProxy.Next(2, 100);
            DummyClass d = new DummyClass(m);
            string format = @"#{Test1} #{Test1}";

            // Use reflection to create an instance of RandomFactory
            Type randomFactoryType = typeof(RandomProxy).Assembly.GetType("Faker.Random.RandomFactory");
            object r = Activator.CreateInstance(randomFactoryType, d, LocaleType.en);

            // Use reflection to call Next method
            MethodInfo nextMethod = randomFactoryType.GetMethod("Next", new[] { typeof(string) });

            var result = (string)nextMethod.Invoke(r, new object[] { format });
            string[] numbers = result.Split(' ');
            System.Diagnostics.Debug.Assert(numbers.Length == 2);
            System.Diagnostics.Debug.Assert(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
            System.Diagnostics.Debug.Assert(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
            System.Diagnostics.Debug.Assert(numbers[0] != numbers[1]);
        }

        [TestMethod]
        public void TestFakerBaseDictionary()
        {
            Name n = new Name();

            // Use reflection to create an instance of RandomFactory
            Type randomFactoryType = typeof(RandomProxy).Assembly.GetType("Faker.Random.RandomFactory");
            object random = Activator.CreateInstance(randomFactoryType, null, LocaleType.en);

            // Use reflection to call GetFakerObjectFromName method
            MethodInfo getFakerObjectMethod = randomFactoryType.GetMethod("GetFakerObjectFromName");
            var result = getFakerObjectMethod.Invoke(random, new object[] { "Name" });

            System.Diagnostics.Debug.Assert(n.GetType() == result.GetType());
        }

        [TestMethod]
        public void TestFakerFillIn()
        {
            string pattern = "@{Name.GetFirstName}";

            // Use reflection to create an instance of RandomFactory
            Type randomFactoryType = typeof(RandomProxy).Assembly.GetType("Faker.Random.RandomFactory");
            object random = Activator.CreateInstance(randomFactoryType, null, LocaleType.en);

            // Use reflection to get the FillInRandomDataFromMethod
            MethodInfo fillInRandomDataFromMethodInfo = randomFactoryType.GetMethod("FillInRandomDataFromMethod");

            List<string> names = new List<string>();
            En en = new En();
            foreach (var n in en.FirstName) names.Add(n);
            //foreach (var n in en.MaleFirstName) names.Add(n);
            //foreach (var n in en.FemaleFirstName) names.Add(n);
            for (int i  = 0; i < 100000; i++)
            {
                var result = (string)fillInRandomDataFromMethodInfo.Invoke(random, new object[] { pattern });
                System.Diagnostics.Debug.Assert(names.Contains(result));
            }
        }
        public class DummyClass
        {
            public int[] Test1 { get; set; }
            public int[] Test2 { get; set; }
            public DummyClass(int i)
            {
                List<int> list = new List<int>(i);
                for (int m = 0; m < i; m++)
                {
                    list.Add(i << m);
                }
                this.Test1 = list.ToArray();
                list = new List<int>(i);
                for (int m = 0; m < i; m++)
                {
                    list.Add(m << (i + 1));
                }
                this.Test2 = list.ToArray();
            }
        }
    }
}