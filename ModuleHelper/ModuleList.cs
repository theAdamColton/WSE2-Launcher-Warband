using System;
using System.Drawing;
using System.IO;

namespace ModuleHelper
{
    public static class ModuleList
    {
        public static ModuleEntry[] GetModuleEntries(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            ModuleEntry[] modules = new ModuleEntry[dirs.Length];

            int i = 0;
            foreach (string d in dirs)
            {
                modules[i] = new ModuleEntry() { ModulePath = d, Name = Path.GetFileName(d) };
                i++;
            }

            return modules;
        }
    }

    public class ModuleEntry
    {
        public string ModulePath;
        public string Name;

        public Image GetBitmap()
        {
            try
            {
                return Image.FromFile(Path.Combine(ModulePath, "main.bmp"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not read main.bmp! {0}", e);
                return null;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
