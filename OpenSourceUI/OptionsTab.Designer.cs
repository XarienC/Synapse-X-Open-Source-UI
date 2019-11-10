namespace OpenSourceUI
{
    partial class OptionsTab
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
            this.OptionMessage = new System.Windows.Forms.Label();
            this.ColourDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // OptionMessage
            // 
            this.OptionMessage.AutoSize = true;
            this.OptionMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionMessage.ForeColor = System.Drawing.Color.White;
            this.OptionMessage.Location = new System.Drawing.Point(65, 116);
            this.OptionMessage.Name = "OptionMessage";
            this.OptionMessage.Size = new System.Drawing.Size(431, 63);
            this.OptionMessage.TabIndex = 12;
            this.OptionMessage.Text = "There\'s nothing here, so feel free to add whatever kind\r\nof options you\'d like he" +
    "re, this is the part where you\r\ncontribute too.";
            // 
            // OptionsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.OptionMessage);
            this.Name = "OptionsTab";
            this.Size = new System.Drawing.Size(558, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OptionMessage;
        private System.Windows.Forms.ColorDialog ColourDialog;
    }
}
