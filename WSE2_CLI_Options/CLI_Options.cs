using ConfigController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSE2_CLI_Options
{
    public class CLI_Options
    {
        public bool IntroDisabled;
        public string Module;
        public string ConfigPath;


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (IntroDisabled)
                sb.Append(" --no-intro");
            sb.Append(" --module" );
            sb.Append(Module);

            if (!(ConfigPath is null))
            {
                sb.Append(" --config-path ");
                sb.Append(ConfigPath);
            }

            return sb.ToString();
        }
    }
}