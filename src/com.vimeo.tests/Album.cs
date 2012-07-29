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
    public class AlbumTestClass
    {
        [TestMethod]
        public void GetAlbum()
        {
            // David Wilson's Album            
            var album = Album.Get("1751001");
            Assert.IsNotNull(album);
        }

        [TestMethod]
        public void Videos()
        {
            // David Wilson's Album            
            var list = Album.Videos("1751001");
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }


    }
}
