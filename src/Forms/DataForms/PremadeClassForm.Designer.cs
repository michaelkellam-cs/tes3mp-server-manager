namespace TES3MP_GUI.src.Forms.DataForms
{
    partial class PremadeClassForm
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
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.majTable = new System.Windows.Forms.TableLayoutPanel();
            this.maj1 = new System.Windows.Forms.Label();
            this.maj2 = new System.Windows.Forms.Label();
            this.maj3 = new System.Windows.Forms.Label();
            this.maj4 = new System.Windows.Forms.Label();
            this.maj5 = new System.Windows.Forms.Label();
            this.majLab = new System.Windows.Forms.Label();
            this.minLab = new System.Windows.Forms.Label();
            this.minTable = new System.Windows.Forms.TableLayoutPanel();
            this.min5 = new System.Windows.Forms.Label();
            this.min4 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.majTable.SuspendLayout();
            this.minTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.topLabel.Location = new System.Drawing.Point(219, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(228, 31);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Premade Classes";
            // 
            // classCombo
            // 
            this.classCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Location = new System.Drawing.Point(243, 43);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(182, 21);
            this.classCombo.TabIndex = 1;
            this.classCombo.SelectedIndexChanged += new System.EventHandler(this.classCombo_SelectedIndexChanged);
            // 
            // majTable
            // 
            this.majTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.majTable.ColumnCount = 5;
            this.majTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.majTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.majTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.majTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.majTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.majTable.Controls.Add(this.maj5, 4, 0);
            this.majTable.Controls.Add(this.maj4, 3, 0);
            this.majTable.Controls.Add(this.maj3, 2, 0);
            this.majTable.Controls.Add(this.maj2, 1, 0);
            this.majTable.Controls.Add(this.maj1, 0, 0);
            this.majTable.Location = new System.Drawing.Point(68, 90);
            this.majTable.Name = "majTable";
            this.majTable.RowCount = 1;
            this.majTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.majTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.majTable.Size = new System.Drawing.Size(533, 35);
            this.majTable.TabIndex = 2;
            // 
            // maj1
            // 
            this.maj1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maj1.AutoSize = true;
            this.maj1.Location = new System.Drawing.Point(37, 11);
            this.maj1.Name = "maj1";
            this.maj1.Size = new System.Drawing.Size(32, 13);
            this.maj1.TabIndex = 0;
            this.maj1.Text = "Skill1";
            // 
            // maj2
            // 
            this.maj2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maj2.AutoSize = true;
            this.maj2.Location = new System.Drawing.Point(143, 11);
            this.maj2.Name = "maj2";
            this.maj2.Size = new System.Drawing.Size(32, 13);
            this.maj2.TabIndex = 1;
            this.maj2.Text = "Skill2";
            // 
            // maj3
            // 
            this.maj3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maj3.AutoSize = true;
            this.maj3.Location = new System.Drawing.Point(249, 11);
            this.maj3.Name = "maj3";
            this.maj3.Size = new System.Drawing.Size(32, 13);
            this.maj3.TabIndex = 2;
            this.maj3.Text = "Skill3";
            // 
            // maj4
            // 
            this.maj4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maj4.AutoSize = true;
            this.maj4.Location = new System.Drawing.Point(355, 11);
            this.maj4.Name = "maj4";
            this.maj4.Size = new System.Drawing.Size(32, 13);
            this.maj4.TabIndex = 3;
            this.maj4.Text = "Skill4";
            // 
            // maj5
            // 
            this.maj5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maj5.AutoSize = true;
            this.maj5.Location = new System.Drawing.Point(462, 11);
            this.maj5.Name = "maj5";
            this.maj5.Size = new System.Drawing.Size(32, 13);
            this.maj5.TabIndex = 4;
            this.maj5.Text = "Skill5";
            // 
            // majLab
            // 
            this.majLab.AutoSize = true;
            this.majLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.majLab.Location = new System.Drawing.Point(294, 67);
            this.majLab.Name = "majLab";
            this.majLab.Size = new System.Drawing.Size(88, 20);
            this.majLab.TabIndex = 3;
            this.majLab.Text = "Major Skills";
            // 
            // minLab
            // 
            this.minLab.AutoSize = true;
            this.minLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minLab.Location = new System.Drawing.Point(294, 128);
            this.minLab.Name = "minLab";
            this.minLab.Size = new System.Drawing.Size(88, 20);
            this.minLab.TabIndex = 4;
            this.minLab.Text = "Minor Skills";
            // 
            // minTable
            // 
            this.minTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.minTable.ColumnCount = 5;
            this.minTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.minTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.minTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.minTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.minTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.minTable.Controls.Add(this.min5, 4, 0);
            this.minTable.Controls.Add(this.min4, 3, 0);
            this.minTable.Controls.Add(this.min3, 2, 0);
            this.minTable.Controls.Add(this.min2, 1, 0);
            this.minTable.Controls.Add(this.min1, 0, 0);
            this.minTable.Location = new System.Drawing.Point(68, 151);
            this.minTable.Name = "minTable";
            this.minTable.RowCount = 1;
            this.minTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.minTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.minTable.Size = new System.Drawing.Size(533, 35);
            this.minTable.TabIndex = 5;
            // 
            // min5
            // 
            this.min5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min5.AutoSize = true;
            this.min5.Location = new System.Drawing.Point(462, 11);
            this.min5.Name = "min5";
            this.min5.Size = new System.Drawing.Size(32, 13);
            this.min5.TabIndex = 4;
            this.min5.Text = "Skill5";
            // 
            // min4
            // 
            this.min4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min4.AutoSize = true;
            this.min4.Location = new System.Drawing.Point(355, 11);
            this.min4.Name = "min4";
            this.min4.Size = new System.Drawing.Size(32, 13);
            this.min4.TabIndex = 3;
            this.min4.Text = "Skill4";
            // 
            // min3
            // 
            this.min3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min3.AutoSize = true;
            this.min3.Location = new System.Drawing.Point(249, 11);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(32, 13);
            this.min3.TabIndex = 2;
            this.min3.Text = "Skill3";
            // 
            // min2
            // 
            this.min2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min2.AutoSize = true;
            this.min2.Location = new System.Drawing.Point(143, 11);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(32, 13);
            this.min2.TabIndex = 1;
            this.min2.Text = "Skill2";
            // 
            // min1
            // 
            this.min1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min1.AutoSize = true;
            this.min1.Location = new System.Drawing.Point(37, 11);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(32, 13);
            this.min1.TabIndex = 0;
            this.min1.Text = "Skill1";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(298, 192);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 6;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // PremadeClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 247);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.minTable);
            this.Controls.Add(this.minLab);
            this.Controls.Add(this.majLab);
            this.Controls.Add(this.majTable);
            this.Controls.Add(this.classCombo);
            this.Controls.Add(this.topLabel);
            this.Name = "PremadeClassForm";
            this.Text = "PremadeClassForm";
            this.majTable.ResumeLayout(false);
            this.majTable.PerformLayout();
            this.minTable.ResumeLayout(false);
            this.minTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.ComboBox classCombo;
        private System.Windows.Forms.TableLayoutPanel majTable;
        private System.Windows.Forms.Label maj5;
        private System.Windows.Forms.Label maj4;
        private System.Windows.Forms.Label maj3;
        private System.Windows.Forms.Label maj2;
        private System.Windows.Forms.Label maj1;
        private System.Windows.Forms.Label majLab;
        private System.Windows.Forms.Label minLab;
        private System.Windows.Forms.TableLayoutPanel minTable;
        private System.Windows.Forms.Label min5;
        private System.Windows.Forms.Label min4;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Button applyBtn;
    }
}