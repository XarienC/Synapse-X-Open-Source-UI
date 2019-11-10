namespace OpenSourceUI
{
    partial class Source
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AttachingLabel = new System.Windows.Forms.Label();
            this.AttachButton = new System.Windows.Forms.Button();
            this.TopMostToggle = new System.Windows.Forms.CheckBox();
            this.MinimizeUIButton = new System.Windows.Forms.Button();
            this.CloseUIButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ChangeColourButton = new System.Windows.Forms.Button();
            this.CreditsTabButton = new System.Windows.Forms.Button();
            this.KillRobloxButton = new System.Windows.Forms.Button();
            this.OptionsTabButton = new System.Windows.Forms.Button();
            this.ScriptHubTabButton = new System.Windows.Forms.Button();
            this.ExecutorTabButton = new System.Windows.Forms.Button();
            this.IntroTabButton = new System.Windows.Forms.Button();
            this.SelectedPanel = new System.Windows.Forms.Panel();
            this.TopColourPanel = new System.Windows.Forms.Panel();
            this.SideColourPanel = new System.Windows.Forms.Panel();
            this.ColourDialog = new System.Windows.Forms.ColorDialog();
            this.OptionsTab = new OpenSourceUI.OptionsTab();
            this.ScriptHubTab = new OpenSourceUI.ScriptHubTab();
            this.ExecutingTab = new OpenSourceUI.ExecutingTab();
            this.IntroductionTab = new OpenSourceUI.IntroductionTab();
            this.CreditsTab = new OpenSourceUI.CreditsTab();
            this.TopPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TopPanel.Controls.Add(this.AttachingLabel);
            this.TopPanel.Controls.Add(this.AttachButton);
            this.TopPanel.Controls.Add(this.TopMostToggle);
            this.TopPanel.Controls.Add(this.MinimizeUIButton);
            this.TopPanel.Controls.Add(this.CloseUIButton);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(695, 41);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // AttachingLabel
            // 
            this.AttachingLabel.AutoSize = true;
            this.AttachingLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachingLabel.ForeColor = System.Drawing.Color.White;
            this.AttachingLabel.Location = new System.Drawing.Point(299, 13);
            this.AttachingLabel.Name = "AttachingLabel";
            this.AttachingLabel.Size = new System.Drawing.Size(109, 17);
            this.AttachingLabel.TabIndex = 11;
            this.AttachingLabel.Text = "Not attached...";
            // 
            // AttachButton
            // 
            this.AttachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AttachButton.FlatAppearance.BorderSize = 0;
            this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachButton.ForeColor = System.Drawing.Color.White;
            this.AttachButton.Location = new System.Drawing.Point(212, 5);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(86, 31);
            this.AttachButton.TabIndex = 12;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = false;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // TopMostToggle
            // 
            this.TopMostToggle.AutoSize = true;
            this.TopMostToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TopMostToggle.FlatAppearance.BorderSize = 0;
            this.TopMostToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostToggle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMostToggle.ForeColor = System.Drawing.Color.White;
            this.TopMostToggle.Location = new System.Drawing.Point(527, 10);
            this.TopMostToggle.Name = "TopMostToggle";
            this.TopMostToggle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopMostToggle.Size = new System.Drawing.Size(81, 21);
            this.TopMostToggle.TabIndex = 3;
            this.TopMostToggle.Text = "Top Most";
            this.TopMostToggle.UseVisualStyleBackColor = false;
            this.TopMostToggle.CheckedChanged += new System.EventHandler(this.TopMostToggle_CheckedChanged);
            // 
            // MinimizeUIButton
            // 
            this.MinimizeUIButton.FlatAppearance.BorderSize = 0;
            this.MinimizeUIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeUIButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeUIButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeUIButton.Location = new System.Drawing.Point(614, 5);
            this.MinimizeUIButton.Name = "MinimizeUIButton";
            this.MinimizeUIButton.Size = new System.Drawing.Size(36, 31);
            this.MinimizeUIButton.TabIndex = 2;
            this.MinimizeUIButton.Text = "_";
            this.MinimizeUIButton.UseVisualStyleBackColor = true;
            this.MinimizeUIButton.Click += new System.EventHandler(this.MinimizeUIButton_Click);
            // 
            // CloseUIButton
            // 
            this.CloseUIButton.FlatAppearance.BorderSize = 0;
            this.CloseUIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseUIButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseUIButton.ForeColor = System.Drawing.Color.White;
            this.CloseUIButton.Location = new System.Drawing.Point(656, 5);
            this.CloseUIButton.Name = "CloseUIButton";
            this.CloseUIButton.Size = new System.Drawing.Size(36, 31);
            this.CloseUIButton.TabIndex = 1;
            this.CloseUIButton.Text = "✕";
            this.CloseUIButton.UseVisualStyleBackColor = true;
            this.CloseUIButton.Click += new System.EventHandler(this.CloseUIButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "S^X Open Source UI";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SidePanel.Controls.Add(this.ChangeColourButton);
            this.SidePanel.Controls.Add(this.CreditsTabButton);
            this.SidePanel.Controls.Add(this.KillRobloxButton);
            this.SidePanel.Controls.Add(this.OptionsTabButton);
            this.SidePanel.Controls.Add(this.ScriptHubTabButton);
            this.SidePanel.Controls.Add(this.ExecutorTabButton);
            this.SidePanel.Controls.Add(this.IntroTabButton);
            this.SidePanel.Controls.Add(this.SelectedPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 41);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(137, 321);
            this.SidePanel.TabIndex = 1;
            // 
            // ChangeColourButton
            // 
            this.ChangeColourButton.FlatAppearance.BorderSize = 0;
            this.ChangeColourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColourButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColourButton.ForeColor = System.Drawing.Color.White;
            this.ChangeColourButton.Location = new System.Drawing.Point(24, 9);
            this.ChangeColourButton.Name = "ChangeColourButton";
            this.ChangeColourButton.Size = new System.Drawing.Size(90, 28);
            this.ChangeColourButton.TabIndex = 9;
            this.ChangeColourButton.Text = "Colour";
            this.ChangeColourButton.UseVisualStyleBackColor = true;
            this.ChangeColourButton.Click += new System.EventHandler(this.ChangeColourButton_Click);
            // 
            // CreditsTabButton
            // 
            this.CreditsTabButton.FlatAppearance.BorderSize = 0;
            this.CreditsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsTabButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsTabButton.ForeColor = System.Drawing.Color.White;
            this.CreditsTabButton.Location = new System.Drawing.Point(7, 226);
            this.CreditsTabButton.Name = "CreditsTabButton";
            this.CreditsTabButton.Size = new System.Drawing.Size(130, 39);
            this.CreditsTabButton.TabIndex = 8;
            this.CreditsTabButton.Text = "Credits";
            this.CreditsTabButton.UseVisualStyleBackColor = true;
            this.CreditsTabButton.Click += new System.EventHandler(this.CreditsTabButton_Click);
            // 
            // KillRobloxButton
            // 
            this.KillRobloxButton.FlatAppearance.BorderSize = 0;
            this.KillRobloxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillRobloxButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillRobloxButton.ForeColor = System.Drawing.Color.White;
            this.KillRobloxButton.Location = new System.Drawing.Point(3, 279);
            this.KillRobloxButton.Name = "KillRobloxButton";
            this.KillRobloxButton.Size = new System.Drawing.Size(130, 39);
            this.KillRobloxButton.TabIndex = 7;
            this.KillRobloxButton.Text = "Kill Roblox";
            this.KillRobloxButton.UseVisualStyleBackColor = true;
            this.KillRobloxButton.Click += new System.EventHandler(this.KillRobloxButton_Click);
            // 
            // OptionsTabButton
            // 
            this.OptionsTabButton.FlatAppearance.BorderSize = 0;
            this.OptionsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsTabButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsTabButton.ForeColor = System.Drawing.Color.White;
            this.OptionsTabButton.Location = new System.Drawing.Point(7, 181);
            this.OptionsTabButton.Name = "OptionsTabButton";
            this.OptionsTabButton.Size = new System.Drawing.Size(130, 39);
            this.OptionsTabButton.TabIndex = 6;
            this.OptionsTabButton.Text = "Options";
            this.OptionsTabButton.UseVisualStyleBackColor = true;
            this.OptionsTabButton.Click += new System.EventHandler(this.OptionsTabButton_Click);
            // 
            // ScriptHubTabButton
            // 
            this.ScriptHubTabButton.FlatAppearance.BorderSize = 0;
            this.ScriptHubTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHubTabButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHubTabButton.ForeColor = System.Drawing.Color.White;
            this.ScriptHubTabButton.Location = new System.Drawing.Point(7, 136);
            this.ScriptHubTabButton.Name = "ScriptHubTabButton";
            this.ScriptHubTabButton.Size = new System.Drawing.Size(130, 39);
            this.ScriptHubTabButton.TabIndex = 5;
            this.ScriptHubTabButton.Text = "Script Hub";
            this.ScriptHubTabButton.UseVisualStyleBackColor = true;
            this.ScriptHubTabButton.Click += new System.EventHandler(this.ScriptHubTabButton_Click);
            // 
            // ExecutorTabButton
            // 
            this.ExecutorTabButton.FlatAppearance.BorderSize = 0;
            this.ExecutorTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecutorTabButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecutorTabButton.ForeColor = System.Drawing.Color.White;
            this.ExecutorTabButton.Location = new System.Drawing.Point(7, 91);
            this.ExecutorTabButton.Name = "ExecutorTabButton";
            this.ExecutorTabButton.Size = new System.Drawing.Size(130, 39);
            this.ExecutorTabButton.TabIndex = 4;
            this.ExecutorTabButton.Text = "Executor";
            this.ExecutorTabButton.UseVisualStyleBackColor = true;
            this.ExecutorTabButton.Click += new System.EventHandler(this.ExecutorTabButton_Click);
            // 
            // IntroTabButton
            // 
            this.IntroTabButton.FlatAppearance.BorderSize = 0;
            this.IntroTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntroTabButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroTabButton.ForeColor = System.Drawing.Color.White;
            this.IntroTabButton.Location = new System.Drawing.Point(7, 46);
            this.IntroTabButton.Name = "IntroTabButton";
            this.IntroTabButton.Size = new System.Drawing.Size(130, 39);
            this.IntroTabButton.TabIndex = 3;
            this.IntroTabButton.Text = "Introduction";
            this.IntroTabButton.UseVisualStyleBackColor = true;
            this.IntroTabButton.Click += new System.EventHandler(this.IntroTabButton_Click);
            // 
            // SelectedPanel
            // 
            this.SelectedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            this.SelectedPanel.Location = new System.Drawing.Point(0, 46);
            this.SelectedPanel.Name = "SelectedPanel";
            this.SelectedPanel.Size = new System.Drawing.Size(6, 39);
            this.SelectedPanel.TabIndex = 2;
            // 
            // TopColourPanel
            // 
            this.TopColourPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            this.TopColourPanel.Location = new System.Drawing.Point(0, 40);
            this.TopColourPanel.Name = "TopColourPanel";
            this.TopColourPanel.Size = new System.Drawing.Size(695, 1);
            this.TopColourPanel.TabIndex = 2;
            // 
            // SideColourPanel
            // 
            this.SideColourPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            this.SideColourPanel.Location = new System.Drawing.Point(136, 40);
            this.SideColourPanel.Name = "SideColourPanel";
            this.SideColourPanel.Size = new System.Drawing.Size(1, 327);
            this.SideColourPanel.TabIndex = 3;
            // 
            // OptionsTab
            // 
            this.OptionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OptionsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTab.Location = new System.Drawing.Point(137, 41);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Size = new System.Drawing.Size(558, 321);
            this.OptionsTab.TabIndex = 7;
            // 
            // ScriptHubTab
            // 
            this.ScriptHubTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptHubTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptHubTab.Location = new System.Drawing.Point(137, 41);
            this.ScriptHubTab.Name = "ScriptHubTab";
            this.ScriptHubTab.Size = new System.Drawing.Size(558, 321);
            this.ScriptHubTab.TabIndex = 6;
            // 
            // ExecutingTab
            // 
            this.ExecutingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExecutingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExecutingTab.Location = new System.Drawing.Point(137, 41);
            this.ExecutingTab.Name = "ExecutingTab";
            this.ExecutingTab.Size = new System.Drawing.Size(558, 321);
            this.ExecutingTab.TabIndex = 5;
            // 
            // IntroductionTab
            // 
            this.IntroductionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.IntroductionTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntroductionTab.Location = new System.Drawing.Point(137, 41);
            this.IntroductionTab.Name = "IntroductionTab";
            this.IntroductionTab.Size = new System.Drawing.Size(558, 321);
            this.IntroductionTab.TabIndex = 4;
            // 
            // CreditsTab
            // 
            this.CreditsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CreditsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditsTab.Location = new System.Drawing.Point(137, 41);
            this.CreditsTab.Name = "CreditsTab";
            this.CreditsTab.Size = new System.Drawing.Size(558, 321);
            this.CreditsTab.TabIndex = 8;
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(695, 362);
            this.Controls.Add(this.CreditsTab);
            this.Controls.Add(this.OptionsTab);
            this.Controls.Add(this.ScriptHubTab);
            this.Controls.Add(this.ExecutingTab);
            this.Controls.Add(this.IntroductionTab);
            this.Controls.Add(this.SideColourPanel);
            this.Controls.Add(this.TopColourPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Source";
            this.Text = "Open Source UI";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button IntroTabButton;
        private System.Windows.Forms.Panel SelectedPanel;
        private System.Windows.Forms.Button OptionsTabButton;
        private System.Windows.Forms.Button ScriptHubTabButton;
        private System.Windows.Forms.Button ExecutorTabButton;
        private System.Windows.Forms.Button CloseUIButton;
        private System.Windows.Forms.Button CreditsTabButton;
        private System.Windows.Forms.Button KillRobloxButton;
        private System.Windows.Forms.Panel TopColourPanel;
        private System.Windows.Forms.Panel SideColourPanel;
        private System.Windows.Forms.CheckBox TopMostToggle;
        private System.Windows.Forms.Button MinimizeUIButton;
        private System.Windows.Forms.Label AttachingLabel;
        private System.Windows.Forms.Button AttachButton;
        private IntroductionTab IntroductionTab;
        private ExecutingTab ExecutingTab;
        private ScriptHubTab ScriptHubTab;
        private System.Windows.Forms.Button ChangeColourButton;
        private System.Windows.Forms.ColorDialog ColourDialog;
        private OptionsTab OptionsTab;
        private CreditsTab CreditsTab;
    }
}

