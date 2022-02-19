using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Config_Controller
{
    public static class RglFile
    {
        private static string DefaultPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"\Documents\Mount&Blade Warband\rgl_config.txt");


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

            foreach (string line in File.ReadLines(path))
            {
                Console.Write("Reading line: ");
                if (line == "")
                {
                    continue;
                }
                string[] splits = Regex.Split(line, " = ");
                if (splits.Length < 2)
                {
                    Console.WriteLine("Error parsing line");
                    continue;
                }


                Console.Write("[");
                foreach (string s in splits)
                {
                    Console.Write("\"{0}\", ", s);
                }
                Console.WriteLine("]");

                if (!conf.entries.ContainsKey(splits[0]))
                {
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
            try
            {
                using (StreamWriter st = File.CreateText(path))
                {
                    foreach (KeyValuePair<String, String> keyValue in config.entries)
                    {
                        Console.WriteLine("Saving {0} = {1}", keyValue.Key, keyValue.Value);
                        st.WriteLine(String.Format("{0} = {1}", keyValue.Key, keyValue.Value));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Writing setting \"{0}\"! Exiting", e);
                return false;
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
}
