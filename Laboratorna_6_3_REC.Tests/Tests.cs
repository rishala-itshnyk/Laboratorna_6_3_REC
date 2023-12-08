using System;
using NUnit.Framework;

namespace Laboratorna_6_3_REC.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] arr = { 8, 4, 3, 4, 10 };
            int size = arr.Length;

            int result = Program.FindMinRecursive(arr, size, 0, arr[0]);

            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void Test2()
        {
            int[] arr = { 8, 4, 3, 4, 10 };
            int size = arr.Length;

            int result = Program.FindMinTRecursive(arr, size, 0, arr[0]);

            Assert.AreEqual(3, result);
        }
    }
}