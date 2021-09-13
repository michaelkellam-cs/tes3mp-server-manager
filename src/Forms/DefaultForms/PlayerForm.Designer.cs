namespace TES3MP_GUI
{
    partial class PlayerForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.attributesBtn = new System.Windows.Forms.Button();
            this.birthsignsBtn = new System.Windows.Forms.Button();
            this.classesBtn = new System.Windows.Forms.Button();
            this.diseasesBtn = new System.Windows.Forms.Button();
            this.levelBtn = new System.Windows.Forms.Button();
            this.racesButton = new System.Windows.Forms.Button();
            this.skillsBtn = new System.Windows.Forms.Button();
            this.raceGenderLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(319, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(148, 26);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Player Design";
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.password);
            this.loginPanel.Controls.Add(this.username);
            this.loginPanel.Controls.Add(this.passLabel);
            this.loginPanel.Controls.Add(this.userLabel);
            this.loginPanel.Location = new System.Drawing.Point(12, 159);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(200, 100);
            this.loginPanel.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(98, 57);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 3;
            this.password.Text = "*HIDDEN*";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(98, 18);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 16);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(3, 57);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(71, 16);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(3, 18);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(74, 16);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username:";
            // 
            // passButton
            // 
            this.passButton.Location = new System.Drawing.Point(60, 265);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(109, 23);
            this.passButton.TabIndex = 3;
            this.passButton.Text = "Show Password";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(359, 415);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // attributesBtn
            // 
            this.attributesBtn.Location = new System.Drawing.Point(359, 68);
            this.attributesBtn.Name = "attributesBtn";
            this.attributesBtn.Size = new System.Drawing.Size(75, 23);
            this.attributesBtn.TabIndex = 5;
            this.attributesBtn.Text = "Attributes";
            this.attributesBtn.UseVisualStyleBackColor = true;
            this.attributesBtn.Click += new System.EventHandler(this.attributesBtn_Click);
            // 
            // birthsignsBtn
            // 
            this.birthsignsBtn.Location = new System.Drawing.Point(359, 97);
            this.birthsignsBtn.Name = "birthsignsBtn";
            this.birthsignsBtn.Size = new System.Drawing.Size(75, 23);
            this.birthsignsBtn.TabIndex = 6;
            this.birthsignsBtn.Text = "Birthsigns";
            this.birthsignsBtn.UseVisualStyleBackColor = true;
            this.birthsignsBtn.Click += new System.EventHandler(this.birthsignsBtn_Click);
            // 
            // classesBtn
            // 
            this.classesBtn.Location = new System.Drawing.Point(359, 126);
            this.classesBtn.Name = "classesBtn";
            this.classesBtn.Size = new System.Drawing.Size(75, 23);
            this.classesBtn.TabIndex = 7;
            this.classesBtn.Text = "Classes";
            this.classesBtn.UseVisualStyleBackColor = true;
            this.classesBtn.Click += new System.EventHandler(this.classesBtn_Click);
            // 
            // diseasesBtn
            // 
            this.diseasesBtn.Location = new System.Drawing.Point(359, 155);
            this.diseasesBtn.Name = "diseasesBtn";
            this.diseasesBtn.Size = new System.Drawing.Size(75, 23);
            this.diseasesBtn.TabIndex = 8;
            this.diseasesBtn.Text = "Diseases";
            this.diseasesBtn.UseVisualStyleBackColor = true;
            this.diseasesBtn.Click += new System.EventHandler(this.diseasesBtn_Click);
            // 
            // levelBtn
            // 
            this.levelBtn.Location = new System.Drawing.Point(359, 184);
            this.levelBtn.Name = "levelBtn";
            this.levelBtn.Size = new System.Drawing.Size(75, 23);
            this.levelBtn.TabIndex = 9;
            this.levelBtn.Text = "Level";
            this.levelBtn.UseVisualStyleBackColor = true;
            this.levelBtn.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // racesButton
            // 
            this.racesButton.Location = new System.Drawing.Point(349, 213);
            this.racesButton.Name = "racesButton";
            this.racesButton.Size = new System.Drawing.Size(94, 23);
            this.racesButton.TabIndex = 10;
            this.racesButton.Text = "Race/Gender";
            this.racesButton.UseVisualStyleBackColor = true;
            this.racesButton.Click += new System.EventHandler(this.racesButton_Click);
            // 
            // skillsBtn
            // 
            this.skillsBtn.Location = new System.Drawing.Point(359, 242);
            this.skillsBtn.Name = "skillsBtn";
            this.skillsBtn.Size = new System.Drawing.Size(75, 23);
            this.skillsBtn.TabIndex = 11;
            this.skillsBtn.Text = "Skills";
            this.skillsBtn.UseVisualStyleBackColor = true;
            // 
            // raceGenderLabel
            // 
            this.raceGenderLabel.AutoSize = true;
            this.raceGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.raceGenderLabel.Location = new System.Drawing.Point(71, 140);
            this.raceGenderLabel.Name = "raceGenderLabel";
            this.raceGenderLabel.Size = new System.Drawing.Size(89, 16);
            this.raceGenderLabel.TabIndex = 12;
            this.raceGenderLabel.Text = "Race Gender";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.raceGenderLabel);
            this.Controls.Add(this.skillsBtn);
            this.Controls.Add(this.racesButton);
            this.Controls.Add(this.levelBtn);
            this.Controls.Add(this.diseasesBtn);
            this.Controls.Add(this.classesBtn);
            this.Controls.Add(this.birthsignsBtn);
            this.Controls.Add(this.attributesBtn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.topLabel);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button attributesBtn;
        private System.Windows.Forms.Button birthsignsBtn;
        private System.Windows.Forms.Button classesBtn;
        private System.Windows.Forms.Button diseasesBtn;
        private System.Windows.Forms.Button levelBtn;
        private System.Windows.Forms.Button racesButton;
        private System.Windows.Forms.Button skillsBtn;
        private System.Windows.Forms.Label raceGenderLabel;
    }
}