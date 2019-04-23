using System;
using System.Diagnostics;
using System.Windows.Forms;
using LOLSensFix.Configuration;
using LOLSensFix.Utils;

namespace LOLSensFix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sensTrackBar.Value = LsfConfig.Get().StaticSensitivityValue;
            startWithWindowsCheckbox.Checked = AutorunManager.IsAutorunning();
        }

        private void setCurrentButton_Click(object sender, EventArgs e)
        {
            sensTrackBar.Value = WinAPI.GetSensitivity();
        }

        private void sensitivityChecker_Tick(object sender, EventArgs e)
        {
            var prcs = Process.GetProcessesByName("LeagueClient");

            if (prcs.Length == 0)
            {
                return;
            }

            var current = WinAPI.GetSensitivity();
            var required = sensTrackBar.Value;

            if (required != current)
            {
                WinAPI.SetSensitivity(required);
            }
        }

        private void sensTrackBar_Scroll(object sender)
        {
            var val = sensTrackBar.Value;

            sensLabel.Text = $"Required sensitivity: {val}";
            LsfConfig.Get().StaticSensitivityValue = val;
            LsfConfig.Save();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.ShowBalloonTip(1000, "LSF",
                "Application is hidden now.\n" +
                "Click on the notify icon to show it again.",
                ToolTipIcon.Info);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void projectPageItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/0x25CBFC4F");
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Visible = !Visible;
            }
        }

        private void startWithWindowsCheckbox_CheckedChanged(object sender)
        {
            AutorunManager.SetAutorunning(startWithWindowsCheckbox.Checked);
            startWithWindowsCheckbox.Checked = AutorunManager.IsAutorunning();
        }
    }
}
