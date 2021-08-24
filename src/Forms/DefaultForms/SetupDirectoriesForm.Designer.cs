namespace TES3MP_GUI.src.Forms.DefaultForms
{
    partial class SetupDirectoriesForm
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
            this.topLabel = new System.Windows.Forms.Label();
            this.serverDirLabel = new System.Windows.Forms.Label();
            this.serverDirText = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.topLabel.Location = new System.Drawing.Point(170, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(155, 26);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Set Directories";
            // 
            // serverDirLabel
            // 
            this.serverDirLabel.AutoSize = true;
            this.serverDirLabel.Location = new System.Drawing.Point(119, 35);
            this.serverDirLabel.Name = "serverDirLabel";
            this.serverDirLabel.Size = new System.Drawing.Size(287, 39);
            this.serverDirLabel.TabIndex = 1;
            this.serverDirLabel.Text = "Server Directory\r\nYou can find this by cd\'ing into your TES3MP server folder, \r\nt" +
    "hen typing \"pwd\", and pasting in the output.";
            this.serverDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverDirText
            // 
            this.serverDirText.Location = new System.Drawing.Point(152, 77);
            this.serverDirText.Name = "serverDirText";
            this.serverDirText.Size = new System.Drawing.Size(212, 20);
            this.serverDirText.TabIndex = 2;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(220, 103);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // SetupDirectoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 140);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.serverDirText);
            this.Controls.Add(this.serverDirLabel);
            this.Controls.Add(this.topLabel);
            this.Name = "SetupDirectoriesForm";
            this.Text = "SetupDirectoriesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label serverDirLabel;
        private System.Windows.Forms.TextBox serverDirText;
        private System.Windows.Forms.Button applyBtn;
    }
}