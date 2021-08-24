namespace TES3MP_GUI
{
    partial class LoginForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.pKeyBtn = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.pKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(235, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(133, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "TES3 Server GUI";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(268, 29);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(255, 45);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 0;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(268, 68);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(58, 13);
            this.ipLabel.TabIndex = 7;
            this.ipLabel.Text = "IP Address";
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(255, 84);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(100, 20);
            this.ipTextbox.TabIndex = 1;
            // 
            // pKeyBtn
            // 
            this.pKeyBtn.Location = new System.Drawing.Point(263, 110);
            this.pKeyBtn.Name = "pKeyBtn";
            this.pKeyBtn.Size = new System.Drawing.Size(75, 23);
            this.pKeyBtn.TabIndex = 2;
            this.pKeyBtn.Text = "Private Key";
            this.pKeyBtn.UseVisualStyleBackColor = true;
            this.pKeyBtn.Click += new System.EventHandler(this.pKeyBtn_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(263, 139);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pKeyLabel
            // 
            this.pKeyLabel.AutoSize = true;
            this.pKeyLabel.Location = new System.Drawing.Point(344, 115);
            this.pKeyLabel.Name = "pKeyLabel";
            this.pKeyLabel.Size = new System.Drawing.Size(81, 13);
            this.pKeyLabel.TabIndex = 8;
            this.pKeyLabel.Text = "No Key Loaded";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 194);
            this.Controls.Add(this.pKeyLabel);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.pKeyBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.username);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Button pKeyBtn;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label pKeyLabel;
    }
}

