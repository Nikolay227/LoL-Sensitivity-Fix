namespace LOLSensFix
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formSkin = new FlatUI.FormSkin();
            this.exitButton = new FlatUI.FlatButton();
            this.hideButton = new FlatUI.FlatButton();
            this.sensLabel = new FlatUI.FlatLabel();
            this.sensTrackBar = new FlatUI.FlatTrackBar();
            this.setCurrentButton = new FlatUI.FlatButton();
            this.startWithWindowsCheckbox = new FlatUI.FlatCheckBox();
            this.sensitivityChecker = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.flatContextMenuStrip = new FlatUI.FlatContextMenuStrip();
            this.projectPageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formSkin.SuspendLayout();
            this.flatContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin
            // 
            this.formSkin.BackColor = System.Drawing.Color.White;
            this.formSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.formSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.formSkin.Controls.Add(this.exitButton);
            this.formSkin.Controls.Add(this.hideButton);
            this.formSkin.Controls.Add(this.sensLabel);
            this.formSkin.Controls.Add(this.sensTrackBar);
            this.formSkin.Controls.Add(this.setCurrentButton);
            this.formSkin.Controls.Add(this.startWithWindowsCheckbox);
            this.formSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.formSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.formSkin.HeaderMaximize = false;
            this.formSkin.Location = new System.Drawing.Point(0, 0);
            this.formSkin.Name = "formSkin";
            this.formSkin.Size = new System.Drawing.Size(236, 266);
            this.formSkin.TabIndex = 0;
            this.formSkin.Text = "LoL Sensitivity Fixer";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitButton.Location = new System.Drawing.Point(15, 225);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rounded = false;
            this.exitButton.Size = new System.Drawing.Size(209, 24);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "exit";
            this.exitButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.Transparent;
            this.hideButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hideButton.Location = new System.Drawing.Point(15, 195);
            this.hideButton.Name = "hideButton";
            this.hideButton.Rounded = false;
            this.hideButton.Size = new System.Drawing.Size(209, 24);
            this.hideButton.TabIndex = 6;
            this.hideButton.Text = "hide";
            this.hideButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // sensLabel
            // 
            this.sensLabel.BackColor = System.Drawing.Color.Transparent;
            this.sensLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sensLabel.ForeColor = System.Drawing.Color.White;
            this.sensLabel.Location = new System.Drawing.Point(12, 67);
            this.sensLabel.Name = "sensLabel";
            this.sensLabel.Size = new System.Drawing.Size(212, 13);
            this.sensLabel.TabIndex = 5;
            this.sensLabel.Text = "<UNKNOWN>";
            this.sensLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sensTrackBar
            // 
            this.sensTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.sensTrackBar.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.sensTrackBar.Location = new System.Drawing.Point(12, 83);
            this.sensTrackBar.Maximum = 10;
            this.sensTrackBar.Minimum = 0;
            this.sensTrackBar.Name = "sensTrackBar";
            this.sensTrackBar.ShowValue = false;
            this.sensTrackBar.Size = new System.Drawing.Size(212, 23);
            this.sensTrackBar.Style = FlatUI.FlatTrackBar.ElementStyle.Slider;
            this.sensTrackBar.TabIndex = 4;
            this.sensTrackBar.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sensTrackBar.Value = 0;
            this.sensTrackBar.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.sensTrackBar_Scroll);
            // 
            // setCurrentButton
            // 
            this.setCurrentButton.BackColor = System.Drawing.Color.Transparent;
            this.setCurrentButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.setCurrentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCurrentButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setCurrentButton.Location = new System.Drawing.Point(12, 112);
            this.setCurrentButton.Name = "setCurrentButton";
            this.setCurrentButton.Rounded = false;
            this.setCurrentButton.Size = new System.Drawing.Size(212, 24);
            this.setCurrentButton.TabIndex = 3;
            this.setCurrentButton.Text = "set current";
            this.setCurrentButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.setCurrentButton.Click += new System.EventHandler(this.setCurrentButton_Click);
            // 
            // startWithWindowsCheckbox
            // 
            this.startWithWindowsCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.startWithWindowsCheckbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.startWithWindowsCheckbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.startWithWindowsCheckbox.Checked = false;
            this.startWithWindowsCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startWithWindowsCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.startWithWindowsCheckbox.Location = new System.Drawing.Point(51, 155);
            this.startWithWindowsCheckbox.Name = "startWithWindowsCheckbox";
            this.startWithWindowsCheckbox.Size = new System.Drawing.Size(140, 22);
            this.startWithWindowsCheckbox.Style = FlatUI.FlatCheckBox.StyleOptions.Style1;
            this.startWithWindowsCheckbox.TabIndex = 0;
            this.startWithWindowsCheckbox.Text = "Start with Windows";
            this.startWithWindowsCheckbox.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.startWithWindowsCheckbox_CheckedChanged);
            // 
            // sensitivityChecker
            // 
            this.sensitivityChecker.Enabled = true;
            this.sensitivityChecker.Interval = 1000;
            this.sensitivityChecker.Tick += new System.EventHandler(this.sensitivityChecker_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "LSF";
            this.notifyIcon.ContextMenuStrip = this.flatContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LoL Sensitivity Fixer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // flatContextMenuStrip
            // 
            this.flatContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatContextMenuStrip.ForeColor = System.Drawing.Color.White;
            this.flatContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectPageItem,
            this.separatorItem,
            this.exitItem});
            this.flatContextMenuStrip.Name = "flatContextMenuStrip";
            this.flatContextMenuStrip.ShowImageMargin = false;
            this.flatContextMenuStrip.Size = new System.Drawing.Size(140, 54);
            // 
            // projectPageItem
            // 
            this.projectPageItem.Name = "projectPageItem";
            this.projectPageItem.Size = new System.Drawing.Size(139, 22);
            this.projectPageItem.Text = "Visit project page";
            this.projectPageItem.Click += new System.EventHandler(this.projectPageItem_Click);
            // 
            // separatorItem
            // 
            this.separatorItem.Name = "separatorItem";
            this.separatorItem.Size = new System.Drawing.Size(136, 6);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(139, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(236, 266);
            this.ControlBox = false;
            this.Controls.Add(this.formSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL Sensitivity Fix";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formSkin.ResumeLayout(false);
            this.flatContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin;
        private FlatUI.FlatCheckBox startWithWindowsCheckbox;
        private FlatUI.FlatButton setCurrentButton;
        private System.Windows.Forms.Timer sensitivityChecker;
        private FlatUI.FlatLabel sensLabel;
        private FlatUI.FlatTrackBar sensTrackBar;
        private FlatUI.FlatButton exitButton;
        private FlatUI.FlatButton hideButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private FlatUI.FlatContextMenuStrip flatContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem projectPageItem;
        private System.Windows.Forms.ToolStripSeparator separatorItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
    }
}

