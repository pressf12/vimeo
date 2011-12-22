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
    public class ChannelTestClass
    {
        [TestMethod]
        public void GetInfo()
        {
            // whitehouse channel
            var channel = Channel.Get("whitehouse");
            Assert.IsNotNull(channel);
        }

        [TestMethod]
        public void Videos()
        {
            // whitehouse channel
            var list = Channel.Videos("whitehouse");
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }
    }
}
