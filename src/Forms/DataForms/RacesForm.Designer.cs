namespace TES3MP_GUI.DataForms
{
    partial class RacesForm
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.genderLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.raceCombo = new System.Windows.Forms.ComboBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.mainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.topLabel.Location = new System.Drawing.Point(98, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(199, 25);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Player - Gender Race";
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Controls.Add(this.raceCombo, 1, 1);
            this.mainTable.Controls.Add(this.raceLabel, 1, 0);
            this.mainTable.Controls.Add(this.genderLabel, 0, 0);
            this.mainTable.Controls.Add(this.genderCombo, 0, 1);
            this.mainTable.Location = new System.Drawing.Point(89, 37);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Size = new System.Drawing.Size(218, 59);
            this.mainTable.TabIndex = 1;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.genderLabel.Location = new System.Drawing.Point(28, 6);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(53, 16);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender";
            // 
            // raceLabel
            // 
            this.raceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.raceLabel.Location = new System.Drawing.Point(143, 6);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(41, 16);
            this.raceLabel.TabIndex = 1;
            this.raceLabel.Text = "Race";
            // 
            // genderCombo
            // 
            this.genderCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Location = new System.Drawing.Point(3, 33);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(103, 21);
            this.genderCombo.TabIndex = 2;
            // 
            // raceCombo
            // 
            this.raceCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raceCombo.FormattingEnabled = true;
            this.raceCombo.Location = new System.Drawing.Point(112, 33);
            this.raceCombo.Name = "raceCombo";
            this.raceCombo.Size = new System.Drawing.Size(103, 21);
            this.raceCombo.TabIndex = 3;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(167, 97);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(66, 23);
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // RacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 126);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.topLabel);
            this.Name = "RacesForm";
            this.Text = "RacesForm";
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.ComboBox raceCombo;
        private System.Windows.Forms.Button applyBtn;
    }
}