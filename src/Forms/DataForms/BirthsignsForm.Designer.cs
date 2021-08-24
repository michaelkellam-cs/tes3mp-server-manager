using System.Drawing;

namespace TES3MP_GUI.DataForms
{
    partial class BirthsignsForm
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
            this.birthsignsTop = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.currentBirthsign = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.birthCombo = new System.Windows.Forms.ComboBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthsignsTop
            // 
            this.birthsignsTop.AutoSize = true;
            this.birthsignsTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.birthsignsTop.Location = new System.Drawing.Point(175, 9);
            this.birthsignsTop.Name = "birthsignsTop";
            this.birthsignsTop.Size = new System.Drawing.Size(66, 31);
            this.birthsignsTop.TabIndex = 0;
            this.birthsignsTop.Text = "Title";
            this.birthsignsTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.birthCombo);
            this.mainPanel.Controls.Add(this.changeButton);
            this.mainPanel.Controls.Add(this.currentBirthsign);
            this.mainPanel.Location = new System.Drawing.Point(118, 55);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 100);
            this.mainPanel.TabIndex = 1;
            // 
            // currentBirthsign
            // 
            this.currentBirthsign.AutoSize = true;
            this.currentBirthsign.Location = new System.Drawing.Point(59, 12);
            this.currentBirthsign.Name = "currentBirthsign";
            this.currentBirthsign.Size = new System.Drawing.Size(86, 13);
            this.currentBirthsign.TabIndex = 0;
            this.currentBirthsign.Text = "Player\'s Birthsign";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(51, 51);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change Birthsign";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // birthCombo
            // 
            this.birthCombo.FormattingEnabled = true;
            this.birthCombo.Location = new System.Drawing.Point(42, 28);
            this.birthCombo.Name = "birthCombo";
            this.birthCombo.Size = new System.Drawing.Size(121, 21);
            this.birthCombo.TabIndex = 2;
            // 
            // BirthsignsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 187);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.birthsignsTop);
            this.Name = "BirthsignsForm";
            this.Text = "BirthsignsForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label birthsignsTop;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label currentBirthsign;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ComboBox birthCombo;
    }
}