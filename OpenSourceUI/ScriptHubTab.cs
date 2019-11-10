using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSourceUI
{
    public partial class ScriptHubTab : UserControl
    {
        internal static string data;
        public ScriptHubTab()
        {
            InitializeComponent();
        }

        #region Buttons
        private void DarkDexButton_Click(object sender, EventArgs e)
        {
            ScriptHubTab.data = "Dark Dex";
            Functions.Lib.ScriptHub();
            Functions.Lib.ScriptHubMarkAsClosed();
        }

        private void ESPButton_Click(object sender, EventArgs e)
        {
            ScriptHubTab.data = "Unnamed ESP";
            Functions.Lib.ScriptHub();
            Functions.Lib.ScriptHubMarkAsClosed();
        }

        private void MadCityButton_Click(object sender, EventArgs e)
        {
            ScriptHubTab.data = "MadCityHaxx V2";
            Functions.Lib.ScriptHub();
            Functions.Lib.ScriptHubMarkAsClosed();
        }

        private void SSniperButton_Click(object sender, EventArgs e)
        {
            ScriptHubTab.data = "Stream Sniper";
            Functions.Lib.ScriptHub();
            Functions.Lib.ScriptHubMarkAsClosed();
        }

        private void RSpyButton_Click(object sender, EventArgs e)
        {
            ScriptHubTab.data = "Remote Spy";
            Functions.Lib.ScriptHub();
            Functions.Lib.ScriptHubMarkAsClosed();
        }

        private void SDumperButton_Click(object sender, EventArgs e)
        {
            ScriptHubTab.data = "Script Dumper";
            Functions.Lib.ScriptHub();
            Functions.Lib.ScriptHubMarkAsClosed();
        }
        #endregion
    }
}
