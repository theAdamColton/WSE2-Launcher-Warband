using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ConfigController
{
    public class RglConfig
    {
        public Dictionary<String, IniEntry> entries = new Dictionary<string, IniEntry>();

        private static string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\Mount&Blade Warband WSE2\rgl_config.ini";

        public static RglConfig ReadSettings()
        {
            return ReadSettings(DefaultPath);
        }

        public static RglConfig ReadSettings(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File {0} doesn't exist!", path);
                return null;
            }

            RglConfig conf = new RglConfig();

            string section = "";
            foreach (string line in File.ReadLines(path))
            {
                if (line == "")
                {
                    continue;
                }
                if (line[0] == '[')
                {
                    if (Regex.Match(line, @"^\[.*\]$").Success)
                    {
                        section = Regex.Replace(line, @"\[|\]", "");
                        Console.WriteLine("Set section to {0}", section);
                    }
                    continue;
                }
                string[] splits = Regex.Split(line, "[ ]*=[ ]*");
                if (splits.Length < 2)
                {
                    continue;
                }

                Console.WriteLine("Adding IniEntry: [{0}] {1} = {2}", section, splits[0], splits[1]);
                if (!conf.entries.ContainsKey(splits[0]))
                {
                    conf.entries.Add(splits[0], new IniEntry(section, splits[1]));
                }
                else
                {
                    Console.Write("Already Contains key {0}", splits[0]);
                    conf.entries[splits[0]] = new IniEntry(section, splits[1]);
                }
            }
            return conf;
        }

        public static void WriteSettings(RglConfig conf)
        {
            WriteSettings(conf, DefaultPath);
        }

        public static void WriteSettings(RglConfig config, string path)
        {
            if (!File.Exists(path))
            {
                using (File.Create(path)) { }
            }
            foreach (KeyValuePair<String, IniEntry> keyValue in config.entries)
            {
                Console.WriteLine("Saving [{0}] {1} = {2}", keyValue.Value.Section, keyValue.Key, keyValue.Value);

                try
                {
                    IniFile.WriteValue(path, keyValue.Value.Section, keyValue.Key, keyValue.Value.Value);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Writing setting \"{0}\"!", e);
                }
            }
        }

    }

    public class IniEntry
    {
        public string Section;
        public string Value;

        public IniEntry(string Section, string Value)
        {
            this.Value = Value;
            this.Section = Section;
        }
    }

    /// <summary>   
    /// Create a New INI file to store or load data
    /// From https://www.codeproject.com/Articles/1990/INI-Class-using-C
    /// </summary>
    static class IniFile
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// Section name
        /// <PARAM name="Key"></PARAM>
        /// Key Name
        /// <PARAM name="Value"></PARAM>
        /// Value Name
        public static void WriteValue(string path, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public static string ReadValue(string path, string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, path);
            return temp.ToString();

        }
    }
}

