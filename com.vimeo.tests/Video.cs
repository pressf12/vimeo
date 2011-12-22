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
    public class VideoTestClass
    {
        [TestMethod]
        public void GetInfo()
        {
            // David Guetta Feat. Sia - Titanium
            // 
            var video = Video.Get(34035823);
            Assert.IsNotNull(video);
        }
    }
}
