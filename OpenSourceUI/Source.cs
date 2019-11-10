using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib.Specialized;
using sxlib;
using System.IO;
using System.Diagnostics;

namespace OpenSourceUI
{

    public partial class Source : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Source()
        {
            InitializeComponent();
            IntroductionTab.BringToFront();
            Text = Functions.RandomString(Functions.Rnd.Next(10, 32));

            Functions.Lib = SxLib.InitializeWinForms(this, Direct);
            Functions.Lib.Load();
            Functions.Lib.LoadEvent += this.LibraryLoadEvent;
            Functions.Lib.ScriptHubEvent += new SxLibWinForms.SynScriptHubDelegate(SLibOnScriptHubEvent);
        }

        #region Utilities
        public static void FormDrag(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            FormDrag(Handle, e);
        }

        private void MoveSidePanel(Control TabSelect)
        {
            SelectedPanel.Height = TabSelect.Height;
            SelectedPanel.Top = TabSelect.Top;
        }

        public static string Direct = Directory.GetCurrentDirectory(); // Gets the directory of the form

        public bool Attached; // Attach Bool

        public bool Loaded; // Loaded Bool
        #endregion

        #region Side Menu Buttons
        private void IntroTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(IntroTabButton);
            IntroductionTab.BringToFront();
        }

        private void ExecutorTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ExecutorTabButton);
            ExecutingTab.BringToFront();
        }

        private void ScriptHubTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ScriptHubTabButton);
            ScriptHubTab.BringToFront();
        }

        private void OptionsTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(OptionsTabButton);
            OptionsTab.BringToFront();
        }

        private void CreditsTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(CreditsTabButton);
            CreditsTab.BringToFront();
        }
        private void KillRobloxButton_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                process.Kill();
            }
        }
        private void ChangeColourButton_Click(object sender, EventArgs e)
        {
            if (ColourDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedPanel.BackColor = ColourDialog.Color;
                TopColourPanel.BackColor = ColourDialog.Color;
                SideColourPanel.BackColor = ColourDialog.Color;
            }
        }
        #endregion

        #region Top Buttons
        private void CloseUIButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeUIButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopMostToggle_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost ^= true;
        }
        private void AttachButton_Click(object sender, EventArgs e)
        {
            if (!this.Loaded)
            {
                this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                this.AttachingLabel.Text = "Error! Not ready!";
                return;
            }
            // Attaches to Roblox and makes AttachedLabel switch.
            Functions.Lib.Attach();
            Functions.Lib.AttachEvent += this.LibraryAttachEvent;
        }
        #endregion

        #region Attach/Load/Script Hub Events
        private void LibraryLoadEvent(SxLibBase.SynLoadEvents Event, object whatever)
        {
            // This is basically the switch that'll make the label change according to the status of Synapse launching
            switch (Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    this.AttachingLabel.ForeColor = Color.FromArgb(240, 240, 240);
                    this.AttachingLabel.Text = "Checking whitelist...";
                    break;
                case SxLibBase.SynLoadEvents.CHANGING_WL:
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    this.AttachingLabel.Text = "Downloading data...";
                    return;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    this.AttachingLabel.Text = "Checking data...";
                    return;
                case SxLibBase.SynLoadEvents.READY:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 255, 0);
                    this.AttachingLabel.Text = "Ready to Attach!";
                    this.Loaded = true;
                    return;
                default:
                    return;
            }
        }

        private void LibraryAttachEvent(SxLibBase.SynAttachEvents Event, object whatever)
        {
            // This is basically the switch that'll make the label change according to the status of Synapse is in while injecting.
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.CHECKING:
                    this.AttachingLabel.ForeColor = Color.FromArgb(240, 240, 240);
                    this.AttachingLabel.Text = "Checking...";
                    return;
                case SxLibBase.SynAttachEvents.INJECTING:
                    this.AttachingLabel.Text = "Injecting...";
                    return;
                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    this.AttachingLabel.Text = "Checking whitelist...";
                    return;
                case SxLibBase.SynAttachEvents.SCANNING:
                    this.AttachingLabel.Text = "Scanning...";
                    return;
                case SxLibBase.SynAttachEvents.READY:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 255, 0);
                    this.AttachingLabel.Text = "Ready!";
                    this.Attached = true;
                    return;
                case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
                    this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.AttachingLabel.Text = "Error! Failed to attach!";
                    return;
                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.AttachingLabel.Text = "Error! Failed to find Roblox!";
                    return;
                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.AttachingLabel.Text = "Not running latest version! Updating...";
                    return;
                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    break;
                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.AttachingLabel.Text = "Error! Already injected!";
                    break;
                default:
                    return;
            }
        }

        private static void SLibOnScriptHubEvent(List<SxLibBase.SynHubEntry> Entries)
        {
            foreach (SxLibBase.SynHubEntry synHubEntry in Entries)
            {
                bool flag = ScriptHubTab.data == synHubEntry.Name;
                if (flag)
                {
                    synHubEntry.Execute();
                }
            }
        }


        #endregion

    }

}
