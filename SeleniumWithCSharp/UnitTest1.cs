using NUnit.Framework;
using System;

namespace SeleniumWithCSharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
            
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}