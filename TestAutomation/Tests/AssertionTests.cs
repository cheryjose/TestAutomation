using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NUnit.Framework;
using Automtion.Test.UI.Common.NUnit;
using Automtion.Test.UI.Common.Tests;

namespace Automtion.Test.UI.Common.Tests
{
    [TestFixture]
    public class NlogConfiguration
    {
        private static Logger log;
        private SampleClass testClass1;
        private SampleClass testClass2;

        public NlogConfiguration()
        {
            LogFactory logFactory = new LogFactory();
            log = logFactory.GetCurrentClassLogger();
            testClass1 = new SampleClass()
            {
                Prop1 = "prop1",
                Prop2 = "prop2",
                Prop3 = "prop3"
            };
            testClass2 = new SampleClass()
            {
                Prop1 = "prop1",
                Prop2 = "prop2",
                Prop3 = "prop3"
            };
        }
        [Test]
        public void AssertThatTest()
        {
            Assertions.AssertThat(false, "AssertThat", "Test Passed", "Test Failed");
        }
 
        [Test]
        public void AssertAreEqualTest()
        {
            int expected = 2;
            int actual = 2;
            Assertions.AssertAreEqual(expected, actual, "Assert Are Equal", "Test Passed", "Test Failed");
        }

        [Test]
        public void AssertAreNotEqualTest()
        {
            int expected = 1;
            int actual = 2;
            Assertions.AssertAreNotEqual(expected, actual, "Assert Are Not Equal", "Test Passed", "Test Failed");
        }

        [Test]
        public void AssertAreSameTest()
        {
            var expected = new SampleClass();
            var actual = expected;
            Assertions.AssertAreSame(expected, actual, "Assert Are Same", "Test Passed", "Test Failed");
        }

    }
}
