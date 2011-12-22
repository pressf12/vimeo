using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using com.vimeo.api;
using com.vimeo.api.simple;

namespace com.vimeo.api.tests
{
    [TestClass]
    public class GroupTestClass
    {
        [TestMethod]
        public void GetInfo()
        {
            // musicvideosanygenre group
            var channel = Group.Get("musicvideosanygenre");
            Assert.IsNotNull(channel);
        }

        [TestMethod]
        public void Videos()
        {
            // musicvideosanygenre group
            var list = Group.Videos("musicvideosanygenre");
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void Users()
        {
            // musicvideosanygenre group
            var list = Group.Users("musicvideosanygenre");
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }
    }
}
