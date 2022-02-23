using IniParser;
using IniParser.Model;
using System;
using System.IO;

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
        private static FileIniDataParser _parser;
        public IniData Data;
        private string _path;
        public bool TestingMode = true;

        public RglSettings(string path)
        {
            if (!File.Exists(path))
                Console.WriteLine("path doesn't exist");
            this._path = path;

            if (_parser is null)
                _parser = new FileIniDataParser();

            Data = _parser.ReadFile(path);

            InitializeSettings();
        }

        public RglSettings Clone()
        {
            return new RglSettings(_path);
        }

        public bool WriteSettings()
        {
            return WriteSettings(_path);
        }

        public bool WriteSettings(string path)
        {
            Console.WriteLine("Writing to {0}", path);
            if (_parser is null)
                _parser = new FileIniDataParser();

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
    }
}

