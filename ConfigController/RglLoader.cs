using IniParser;
using IniParser.Model;
using System;

namespace ConfigController
{
    public class RglLoader
    {
        public static string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\Mount&Blade Warband WSE2\rgl_config.ini";

        public static RglSettings ReadSettings()
        {
            return ReadSettings(DefaultPath);
        }

        public static RglSettings ReadSettings(string path)
        {
            return new RglSettings(path);
        }
    }

    public partial class RglSettings
    {
        private FileIniDataParser _parser;
        public IniData Data;
        public bool TestingMode = true;

        public RglSettings(string path)
        {
            _parser = new FileIniDataParser();
            this.Data = _parser.ReadFile(path);
        }

        public bool WriteSettings()
        {
            if (!TestingMode)
            {
                return WriteSettings(RglLoader.DefaultPath);
            }
            else
            {
                return WriteSettings("rgl_junk.ini");
            }
        }

        public bool WriteSettings(string path)
        {
            if (_parser is null)
            {
                _parser = new FileIniDataParser();
            }

            try
            {
                _parser.WriteFile(path, Data);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught {0} writing settings!", e);
                return false;
            }
        }

        public bool GetSettingOrFalse(string section, string key)
        {
            if (Data.TryGetKey(section + ":" + key, out string res))
            {
                return res.ToLower() == "true";
            }
            else
            {
                return false;
            }
        }

        public bool GetSettingOrTrue(string section, string key)
        {
            if (Data.TryGetKey(section + ":" + key, out string res))
            {
                return res.ToLower() == "true";
            }
            else
            {
                return true;
            }
        }

        public string GetSettingOrDefault(string section, string key, string _default)
        {
            if (Data.TryGetKey(section + ":" + key, out string val))
            {
                return val;
            }
            else
            {
                return _default;
            }
        }
    }
}

