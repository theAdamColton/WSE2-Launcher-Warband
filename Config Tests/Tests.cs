using ConfigController;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuleHelper;
using System;
using System.IO;

namespace Config_Tests
{
    [TestClass]
    public class Tests
    {
        string testvalues = "hello = goodbye\nyousay = yes\nIsay = no\nyousay2 = stop\nandIsay = gogogo";
        string module_path = @"C:\Program Files (x86)\Steam\steamapps\common\MountBlade Warband\Modules";

        [TestMethod]
        public void TestReadSimpleSettings()
        {
            File.WriteAllText("testconf.txt", testvalues);
            RglSettings conf = RglLoader.ReadSettings("testconf.txt");
        }

        [TestMethod]
        public void TestWrite()
        {
            Console.WriteLine("Current temp dir is {0}", AppDomain.CurrentDomain.BaseDirectory);
            RglSettings settings = RglLoader.ReadSettings();
            Assert.IsTrue(settings.WriteSettings());
        }

        [TestMethod]
        public void TestDefaultModule()
        {
            RglSettings settings = RglLoader.ReadSettings();
            //Console.WriteLine("bBlood: {0}", settings.bBlood);
            Console.WriteLine("bBlood: {0}", settings.Data["Battle"]["bBlood"]);
        }

        [TestMethod]
        public void TestGetNonexistent()
        {
            RglSettings settings = RglLoader.ReadSettings();
            Console.WriteLine("null: {0}", settings.Data["not"]["existent"]);
        }

        [TestMethod]
        public void TestGenModules()
        {
            ModuleEntry[] m = ModuleList.GetModuleEntries(module_path);
            foreach (var me in m)
            {
                Console.WriteLine("module: {0} path: {1}", me.Name, me.ModulePath);
            }
        }

        [TestMethod]
        public void TestGetModuleImage()
        {
            ModuleEntry[] m = ModuleList.GetModuleEntries(module_path);

            foreach (var me in m)
            {
                Console.WriteLine("module: {0} path: {1}", me.Name, me.ModulePath);
                var im = me.GetBitmap();

                Assert.IsNotNull(im);
            }
        }
    }
}
