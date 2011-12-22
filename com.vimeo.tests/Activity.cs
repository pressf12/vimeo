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
    public class ActivityTestClass
    {
        [TestMethod]
        public void UserDid()
        {
            var list = Activity.UserDid(Configuration.GetKey("username"));
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void HappenedToUser()
        {
            var list = Activity.HappenedToUser(Configuration.GetKey("username"));
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void ContactsDid()
        {
            var list = Activity.ContactsDid(Configuration.GetKey("username"));
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void EveryoneDid()
        {
            var list = Activity.EveryoneDid(Configuration.GetKey("username"));
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

    }
}
