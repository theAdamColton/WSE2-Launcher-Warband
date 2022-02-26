using IniParser.Model;
using System;

namespace ConfigController
{
    public partial class RglSettings
    {
        public abstract class bSetting<T>
        {
            /// <summary>
            /// Name of [section]
            /// </summary>
            private string SectionName;
            /// <summary>
            /// Name of setting key
            /// </summary>
            private string SettingName;
            /// <summary>
            /// The default value returned if the value is not in the ini file
            /// </summary>
            public T Default;
            /// <summary>
            /// Converts string -> T
            /// </summary>
            public abstract Func<string, T> StringToT
            {
                get;
            }

            private IniData Data;

            public bSetting(IniData data, string sectionName, string settingName)
            {
                SectionName = sectionName;
                SettingName = settingName;
                Data = data;
            }

            public T Get()
            {
                return GetSettingOrT(this.SectionName, this.SettingName, this.Default, this.StringToT);
            }
            public void Set(T value)
            {
                Data[SectionName][SettingName] = value.ToString();
            }

            private T GetSettingOrT<T>(string section, string key, T _default, Func<string, T> f)
            {
                string val = Data[section][key];
                if (!(val is null))
                {
                    T res;
                    try
                    {
                        res = f(val);
                        return f(val);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error! Found {0}:{1} = {2}, but could not parse string to {3}. Returning {4}", section, key, val, typeof(T).ToString(), _default);
                        return _default;
                    }
                }
                else
                {
                    Console.WriteLine("Couldn't find {0}:{1}, returning {2}", section, key, _default);
                    return _default;
                }

            }
        }

        public class SettingDefaultTrue : bSetting<bool>
        {
            public new bool Default = true;
            public override Func<string, bool> StringToT { get => s => s.ToLower() == "true"; }
            public SettingDefaultTrue(IniData data, string section, string setting) : base(data, section, setting) { }
        }

        public class SettingDefaultFalse : SettingDefaultTrue
        {
            public new bool Default = false;
            public SettingDefaultFalse(IniData data, string section, string setting) : base(data, section, setting) { }
        }

        public class SettingDefaultString : bSetting<string>
        {
            public override Func<string, string> StringToT { get => s => s; }
            public SettingDefaultString(IniData data, string section, string setting, string _default) : base(data, section, setting)
            {
                Default = _default;
            }
        }

        public class SettingDefaultInt : bSetting<int>
        {
            public override Func<string, int> StringToT { get => s => int.Parse(s); }
            public SettingDefaultInt(IniData data, string section, string setting, int _default) : base(data, section, setting)
            {
                Default = _default;
            }
        }

        /*****************************************************************
        RglSettings are defined here as class members.
        All defined bSettings must be constructed in InitializeSettings
         *****************************************************************/

        // Battle
        public SettingDefaultTrue bBlood;

        // Graphics
        public SettingDefaultFalse bWindowed;
        public SettingDefaultTrue bOnDemandTextures;

        // General 
        public SettingDefaultFalse bShowFrameRate;

        // Sound
        public SettingDefaultTrue bSound;
        public SettingDefaultTrue bMusic;
        public SettingDefaultTrue bOcclusionFilter;
        public SettingDefaultTrue bHrtfFilter;
        public SettingDefaultTrue bDistanceFilter;

        // Launcher Settings
        public SettingDefaultFalse bDisableIntro;
        public SettingDefaultString bDefaultModule;

        private void InitializeSettings()
        {
            bBlood = new SettingDefaultTrue(Data, "Battle", "bBlood");

            bWindowed = new SettingDefaultFalse(Data, "Graphics", "bWindowed");
            bOnDemandTextures = new SettingDefaultFalse(Data, "Graphics", "bOnDemandTextures");

            bShowFrameRate = new SettingDefaultFalse(Data, "General", "bShowFrameRate");

            bSound = new SettingDefaultTrue(Data, "Sound", "bSound");
            bMusic = new SettingDefaultTrue(Data, "Sound", "bMusic");
            bOcclusionFilter = new SettingDefaultFalse(Data, "Sound", "bOcclusionFilter");
            bHrtfFilter = new SettingDefaultFalse(Data, "Sound", "bHrtfFilter");
            bDistanceFilter = new SettingDefaultFalse(Data, "Sound", "bDistanceFilter");

            bDisableIntro = new SettingDefaultFalse(Data, "Launcher", "bDisableIntro");
            bDefaultModule = new SettingDefaultString(Data, "Launcher", "bDefaultModule", "Native");
        }
    }
}
