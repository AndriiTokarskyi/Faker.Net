using System;
using System.Collections.Generic;
using System.Linq;
using Faker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Net.Test.RandomTest
{
    [TestClass]
    public class SelectorTest
    {
        [TestMethod]
        public void TestMultupleSelect()
        {
            // Test the even distribution
            const int iter = 10000000;
            const int sourceSize = 40;
            const int selectionSize = 5;
            const float accuracy = 0.01f;
            int[] source = Enumerable.Range(0, sourceSize).ToArray();
            Dictionary<int, int> resultCount = source.ToDictionary(i => i, _ => 0);

            for (int i = 0; i < iter; i++)
            {
                var result = RandomNumber.Shuffle(source).Take(selectionSize);
                foreach (var r in result) resultCount[r]++;
            }

            foreach(var kvp in resultCount)
            {
                Assert.IsTrue(Math.Abs(kvp.Value / (float)iter - (float)selectionSize / sourceSize) <= accuracy);
            }
        }
    }
}