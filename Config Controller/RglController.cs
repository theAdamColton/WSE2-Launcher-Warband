using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Config_Controller
{
    public static class RglFile
    {
        private static string DefaultPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"\Documents\Mount&Blade Warband\rgl_config.txt");


        public static RglConfig ReadSettings()
        {
            INIFile inifile = new INIFile(DefaultPath);

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

            foreach (string line in File.ReadLines(path)) {
                Console.Write("Reading line: ");
                if (line == "")
                {
                    continue;
                }
                string[] splits = Regex.Split(line, " = ");
                Console.Write("[");
                foreach (string s in splits)
                {
                    Console.Write("\"{0}\", ",s);
                }
                Console.WriteLine("]");

                if (!conf.entries.ContainsKey(splits[0])) {
                    conf.entries.Add(splits[0], splits[1]);
                }
                else
                {
                    Console.Write("Already Contains key {0}", splits[0]);
                    conf.entries[splits[0]] = splits[1];
                }
            }
            return conf;
        }

        public static bool WriteSettings(RglConfig conf)
        {
            return WriteSettings(conf, DefaultPath);
        }

        public static bool WriteSettings(RglConfig config, string path)
        {
            INIFile inifile = new INIFile(path);

            foreach (KeyValuePair<String, String> keyValue in config.entries) {
                Console.WriteLine("Saving {0}{1}", keyValue.Key, keyValue.Value);
                try
                {
                    inifile.IniWriteValue("", keyValue.Key, keyValue.Value);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Writing setting \"{0}\"! Exiting", e);
                    return false;
                }
            }
            return true;
        }

    }

    /// <summary>
    /// The Warband config file, rgl_config.txt is basically an ini file, 
    /// but it has no `[section]` section markers.
    /// </summary>
    public class RglConfig
    {
        public Dictionary<String, String> entries = new Dictionary<string, string>();
    }

    public class INIFile
    {
        public string path { get; private set; }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key,string val,string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key,string def, StringBuilder retVal, int size,string filePath);

        public INIFile(string INIPath)
        {
            path = INIPath;
        }
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }
        
        public string IniReadValue(string Section,string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }
    }
}
