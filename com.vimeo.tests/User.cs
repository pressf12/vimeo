using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using com.vimeo.api;
using com.vimeo.api.simple;

namespace com.vimeo.api.tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UserTestClass
    {

        [TestMethod]
        public void Info()
        {
            var user = User.Info(Configuration.GetKey("username"));
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void Videos()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }

        [TestMethod]
        public void Likes()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }

        [TestMethod]
        public void AppearsIn()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }


        [TestMethod]
        public void Subscriptions()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }


        [TestMethod]
        public void Albums()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }

        [TestMethod]
        public void Channels()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }


        [TestMethod]
        public void Groups()
        {
            var videos = User.Videos(Configuration.GetKey("username"));
            Assert.IsNotNull(videos);
            Assert.IsTrue(videos.Count > 0);
        }
    }
}
