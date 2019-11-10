namespace OpenSourceUI
{
    partial class ExecutingTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExecutingBox = new ScintillaNET.Scintilla();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ExecuteFileButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ExecutingBox
            // 
            this.ExecutingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecutingBox.Location = new System.Drawing.Point(4, 4);
            this.ExecutingBox.Name = "ExecutingBox";
            this.ExecutingBox.Size = new System.Drawing.Size(551, 269);
            this.ExecutingBox.TabIndex = 0;
            this.ExecutingBox.MarginClick += new System.EventHandler<ScintillaNET.MarginClickEventArgs>(this.ExecutingBox_MarginClick);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteButton.FlatAppearance.BorderSize = 0;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Location = new System.Drawing.Point(4, 283);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(96, 30);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ExecuteFileButton
            // 
            this.ExecuteFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteFileButton.FlatAppearance.BorderSize = 0;
            this.ExecuteFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteFileButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteFileButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteFileButton.Location = new System.Drawing.Point(459, 283);
            this.ExecuteFileButton.Name = "ExecuteFileButton";
            this.ExecuteFileButton.Size = new System.Drawing.Size(96, 30);
            this.ExecuteFileButton.TabIndex = 2;
            this.ExecuteFileButton.Text = "Exec File";
            this.ExecuteFileButton.UseVisualStyleBackColor = false;
            this.ExecuteFileButton.Click += new System.EventHandler(this.ExecuteFileButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(120, 283);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 30);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileButton.Location = new System.Drawing.Point(346, 283);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(96, 30);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenFileButton.Location = new System.Drawing.Point(233, 283);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(96, 30);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // ExecutingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExecuteFileButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ExecutingBox);
            this.Name = "ExecutingTab";
            this.Size = new System.Drawing.Size(558, 321);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla ExecutingBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ExecuteFileButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}
