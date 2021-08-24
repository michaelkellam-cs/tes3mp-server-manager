namespace TES3MP_GUI
{
    partial class PortalForm
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
            this.serverToggle = new System.Windows.Forms.Button();
            this.playerCombo = new System.Windows.Forms.ComboBox();
            this.playerButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(363, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(111, 26);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "TES3 GUI";
            // 
            // serverToggle
            // 
            this.serverToggle.Location = new System.Drawing.Point(368, 38);
            this.serverToggle.Name = "serverToggle";
            this.serverToggle.Size = new System.Drawing.Size(99, 23);
            this.serverToggle.TabIndex = 1;
            this.serverToggle.Text = "ServerToggle";
            this.serverToggle.UseVisualStyleBackColor = true;
            this.serverToggle.Click += new System.EventHandler(this.serverToggle_Click);
            // 
            // playerCombo
            // 
            this.playerCombo.FormattingEnabled = true;
            this.playerCombo.Location = new System.Drawing.Point(353, 67);
            this.playerCombo.Name = "playerCombo";
            this.playerCombo.Size = new System.Drawing.Size(121, 21);
            this.playerCombo.TabIndex = 2;
            this.playerCombo.SelectedIndexChanged += new System.EventHandler(this.playerCombo_SelectedIndexChanged);
            // 
            // playerButton
            // 
            this.playerButton.Location = new System.Drawing.Point(368, 94);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(97, 23);
            this.playerButton.TabIndex = 3;
            this.playerButton.Text = "Edit/View Player";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(111, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(601, 440);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 623);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.playerCombo);
            this.Controls.Add(this.serverToggle);
            this.Controls.Add(this.topLabel);
            this.Name = "PortalForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PortalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button serverToggle;
        private System.Windows.Forms.ComboBox playerCombo;
        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}