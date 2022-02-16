using Microsoft.VisualStudio.TestTools.UnitTesting;
using Config_Controller;
using System.IO;
using System.Collections.Generic;
using System;

namespace Config_Tests
{
    [TestClass]
    public class Tests
    {
        string testvalues = "hello = goodbye\nyousay = yes\nIsay = no\nyousay = stop\nandIsay = gogogo";
        [TestMethod]
        public void TestReadSimpleSettings()
        {
            File.WriteAllText("testconf.txt", testvalues);
            RglConfig conf = RglFile.ReadSettings("testconf.txt");
        }

        /// <summary>
        /// This test will fail unless you have warband's rgl_config.txt in your Documents/Mount&BladeWarband/ folder
        ///
        [TestMethod]
        public void TestReadRglSettings()
        {
            RglConfig conf = RglFile.ReadSettings();

            foreach (KeyValuePair<string,string> kv in conf.entries)
            {
                Console.WriteLine("{0} = {1}", kv.Key, kv.Value);
            }
        }
    }
}
