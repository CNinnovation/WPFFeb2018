using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependencyInjectionSample.Tests
{
    public class MockGreetingService : IGreetingService
    {
        public string Greet(string name) => $"test {name}";
    }

    [TestClass]
    public class MyControllerTest
    {
        [TestMethod]
        public void IndexWithSimpleName()
        {
            // arrange
            string expected = "the answer from the service: test abc";
            var controller = new MyController(new MockGreetingService());

            // act
            string actual = controller.Index("abc");

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IndexWithNull()
        {
            // arrange
            var controller = new MyController(new MockGreetingService());

            // act
            string actual = controller.Index(null);

            // assert
        }
    }
}
