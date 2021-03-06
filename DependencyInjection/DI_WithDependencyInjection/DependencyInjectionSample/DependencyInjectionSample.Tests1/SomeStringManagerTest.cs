// <copyright file="SomeStringManagerTest.cs">Copyright ©  2018</copyright>
using System;
using DependencyInjectionSample;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependencyInjectionSample.Tests
{
    /// <summary>This class contains parameterized unit tests for SomeStringManager</summary>
    [PexClass(typeof(SomeStringManager))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SomeStringManagerTest
    {
        /// <summary>Test stub for WorkWithAString(String)</summary>
        [PexMethod]
        public string WorkWithAStringTest([PexAssumeUnderTest]SomeStringManager target, string s)
        {
            string result = target.WorkWithAString(s);
            return result;
            // TODO: add assertions to method SomeStringManagerTest.WorkWithAStringTest(SomeStringManager, String)
        }
    }
}
