using ConfigController;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

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
            RglConfig conf = RglConfig.ReadSettings("testconf.txt");
        }

        /// <summary>
        /// This test will fail unless you have warband's rgl_config.txt in your Documents/Mount&BladeWarband/ folder
        ///
        [TestMethod]
        public void TestRead()
        {
            RglConfig conf = RglConfig.ReadSettings();

            foreach (KeyValuePair<string, IniEntry> kv in conf.entries)
            {
                Console.WriteLine("{0} = {1}", kv.Key, kv.Value.Value);
            }
        }

        [TestMethod]
        public void TestWrite()
        {
            Console.WriteLine("Current temp dir is {0}", AppDomain.CurrentDomain.BaseDirectory);
            RglConfig conf = RglConfig.ReadSettings();
            RglConfig.WriteSettings(conf, "junk.txt");
            RglConfig conf2 = RglConfig.ReadSettings("junk.txt");
            Assert.AreEqual(conf.entries.Count, conf2.entries.Count);
            foreach (string k in conf.entries.Keys)
            {
                Assert.IsTrue(conf2.entries.ContainsKey(k));
                Assert.AreEqual(conf2.entries[k], conf.entries[k]);
            }
        }
    }
}
