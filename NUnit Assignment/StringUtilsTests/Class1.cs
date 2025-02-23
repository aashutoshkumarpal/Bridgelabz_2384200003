using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringUtilsProject;

namespace StringUtilsTests
{
    [TestFixture]
    public class Class1
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_GivenString_ReturnsReversedString()
        {
            Assert.That(_stringUtils.Reverse("hello"), Is.EqualTo("olleh"));
        }

        [Test]
        public void IsPalindrome_GivenPalindrome_ReturnsTrue()
        {
            Assert.That(_stringUtils.IsPalindrome("madam"), Is.True);
        }

        [Test]
        public void IsPalindrome_GivenNonPalindrome_ReturnsFalse()
        {
            Assert.That(_stringUtils.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void ToUpperCase_GivenString_ReturnsUppercaseString()
        {
            Assert.That(_stringUtils.ToUpperCase("hello"), Is.EqualTo("HELLO"));
        }
    }
}
