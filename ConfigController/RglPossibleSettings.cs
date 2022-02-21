namespace ConfigController
{
    public partial class RglSettings
    {
        public bool bBlood
        {
            get
            {
                return GetSettingOrTrue("Battle", "bBlood");
            }
            set
            {
                Data["Battle"]["bBlood"] = value.ToString().ToLower();
            }
        }

    }
}
