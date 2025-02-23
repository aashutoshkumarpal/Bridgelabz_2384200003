using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListManagerProject;

namespace ListManagerTests
{
    public class Class1
    {
        private ListManager _listManager;
        private List<int> _testList;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _testList = new List<int>();
        }

        [Test]
        public void AddElement_GivenElement_IsAddedToList()
        {
            _listManager.AddElement(_testList, 5);
            Assert.That(_testList.Contains(5), Is.True);
        }

        [Test]
        public void RemoveElement_GivenExistingElement_IsRemovedFromList()
        {
            _testList.Add(10);
            _listManager.RemoveElement(_testList, 10);
            Assert.That(_testList.Contains(10), Is.False);
        }

        [Test]
        public void GetSize_GivenList_ReturnsCorrectSize()
        {
            _listManager.AddElement(_testList, 1);
            _listManager.AddElement(_testList, 2);
            Assert.That(_listManager.GetSize(_testList), Is.EqualTo(2));
        }
    }
}
