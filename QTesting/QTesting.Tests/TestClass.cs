using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QTesting;

namespace QTesting.Tests
{
    [TestFixture]
    public class TestClass
    {
        static Premium p1;

        [SetUp]
        public void Init()
        {
            p1 = new Premium();
        }


        [Test]
        public void NoNull()
        {
            Assert.NotNull(p1, "Object not created");
        }

        [Test]
        public void Female18()
        {
            
            float expectedResult = p1.CalculatePremium(18, "female");
            Assert.That(expectedResult, Is.EqualTo(5.0));
        }

        [Test]
        public void Female30()
        {

            float expectedResult = p1.CalculatePremium(30, "female");
            Assert.That(expectedResult, Is.EqualTo(5.0));
        }

        [Test]
        public void Female31()
        {

            float expectedResult = p1.CalculatePremium(31, "female");
            Assert.That(expectedResult, Is.EqualTo(2.5));
        }

        [Test]
        public void Male18()
        {

            float expectedResult = p1.CalculatePremium(18, "male");
            Assert.That(expectedResult, Is.EqualTo(6.0));
        }

        [Test]
        public void Male35()
        {

            float expectedResult = p1.CalculatePremium(35, "male");
            Assert.That(expectedResult, Is.EqualTo(6.0));
        }

        [Test]
        public void Male36()
        {

            float expectedResult = p1.CalculatePremium(36, "male");
            Assert.That(expectedResult, Is.EqualTo(5.0));
        }

        [Test]
        public void Male50()
        {

            float expectedResult = p1.CalculatePremium(50, "male");
            Assert.That(expectedResult, Is.EqualTo(2.5));
        }

        [Test]
        public void Female50()
        {

            float expectedResult = p1.CalculatePremium(50, "female");
            Assert.That(expectedResult, Is.EqualTo(1.25));
        }

    }
}
