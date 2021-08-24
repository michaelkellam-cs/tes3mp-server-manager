namespace TES3MP_GUI.src.Forms.DataForms
{
    partial class CreateClassForm
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
            this.minTable = new System.Windows.Forms.TableLayoutPanel();
            this.minCombo4 = new System.Windows.Forms.ComboBox();
            this.minCombo5 = new System.Windows.Forms.ComboBox();
            this.minCombo3 = new System.Windows.Forms.ComboBox();
            this.minCombo1 = new System.Windows.Forms.ComboBox();
            this.minCombo2 = new System.Windows.Forms.ComboBox();
            this.minLab = new System.Windows.Forms.Label();
            this.majLab = new System.Windows.Forms.Label();
            this.majTable = new System.Windows.Forms.TableLayoutPanel();
            this.majCombo5 = new System.Windows.Forms.ComboBox();
            this.majCombo4 = new System.Windows.Forms.ComboBox();
            this.majCombo3 = new System.Windows.Forms.ComboBox();
            this.majCombo2 = new System.Windows.Forms.ComboBox();
            this.majCombo1 = new System.Windows.Forms.ComboBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.attribsLabel = new System.Windows.Forms.Label();
            this.attribsTable = new System.Windows.Forms.TableLayoutPanel();
            this.attrCombo2 = new System.Windows.Forms.ComboBox();
            this.attrCombo1 = new System.Windows.Forms.ComboBox();
            this.specLabel = new System.Windows.Forms.Label();
            this.specTable = new System.Windows.Forms.TableLayoutPanel();
            this.specCombo = new System.Windows.Forms.ComboBox();
            this.classTextbox = new System.Windows.Forms.TextBox();
            this.classNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.classNameLab = new System.Windows.Forms.Label();
            this.descTable = new System.Windows.Forms.TableLayoutPanel();
            this.descLabel = new System.Windows.Forms.Label();
            this.descTextbox = new System.Windows.Forms.TextBox();
            this.minTable.SuspendLayout();
            this.majTable.SuspendLayout();
            this.attribsTable.SuspendLayout();
            this.specTable.SuspendLayout();
            this.classNameTable.SuspendLayout();
            this.descTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.topLabel.Location = new System.Drawing.Point(300, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(184, 31);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Custom Class";
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
            this.minTable.Controls.Add(this.minCombo4, 0, 0);
            this.minTable.Controls.Add(this.minCombo5, 0, 0);
            this.minTable.Controls.Add(this.minCombo3, 0, 0);
            this.minTable.Controls.Add(this.minCombo1, 0, 0);
            this.minTable.Controls.Add(this.minCombo2, 0, 0);
            this.minTable.Location = new System.Drawing.Point(126, 137);
            this.minTable.Name = "minTable";
            this.minTable.RowCount = 1;
            this.minTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.minTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.minTable.Size = new System.Drawing.Size(533, 35);
            this.minTable.TabIndex = 9;
            // 
            // minCombo4
            // 
            this.minCombo4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minCombo4.FormattingEnabled = true;
            this.minCombo4.Location = new System.Drawing.Point(322, 7);
            this.minCombo4.Name = "minCombo4";
            this.minCombo4.Size = new System.Drawing.Size(99, 21);
            this.minCombo4.TabIndex = 5;
            // 
            // minCombo5
            // 
            this.minCombo5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minCombo5.FormattingEnabled = true;
            this.minCombo5.Location = new System.Drawing.Point(429, 7);
            this.minCombo5.Name = "minCombo5";
            this.minCombo5.Size = new System.Drawing.Size(99, 21);
            this.minCombo5.TabIndex = 4;
            // 
            // minCombo3
            // 
            this.minCombo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minCombo3.FormattingEnabled = true;
            this.minCombo3.Location = new System.Drawing.Point(216, 7);
            this.minCombo3.Name = "minCombo3";
            this.minCombo3.Size = new System.Drawing.Size(99, 21);
            this.minCombo3.TabIndex = 3;
            // 
            // minCombo1
            // 
            this.minCombo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minCombo1.FormattingEnabled = true;
            this.minCombo1.Location = new System.Drawing.Point(4, 7);
            this.minCombo1.Name = "minCombo1";
            this.minCombo1.Size = new System.Drawing.Size(99, 21);
            this.minCombo1.TabIndex = 2;
            // 
            // minCombo2
            // 
            this.minCombo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minCombo2.FormattingEnabled = true;
            this.minCombo2.Location = new System.Drawing.Point(110, 7);
            this.minCombo2.Name = "minCombo2";
            this.minCombo2.Size = new System.Drawing.Size(99, 21);
            this.minCombo2.TabIndex = 1;
            // 
            // minLab
            // 
            this.minLab.AutoSize = true;
            this.minLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minLab.Location = new System.Drawing.Point(343, 114);
            this.minLab.Name = "minLab";
            this.minLab.Size = new System.Drawing.Size(88, 20);
            this.minLab.TabIndex = 8;
            this.minLab.Text = "Minor Skills";
            // 
            // majLab
            // 
            this.majLab.AutoSize = true;
            this.majLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.majLab.Location = new System.Drawing.Point(343, 53);
            this.majLab.Name = "majLab";
            this.majLab.Size = new System.Drawing.Size(88, 20);
            this.majLab.TabIndex = 7;
            this.majLab.Text = "Major Skills";
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
            this.majTable.Controls.Add(this.majCombo5, 4, 0);
            this.majTable.Controls.Add(this.majCombo4, 3, 0);
            this.majTable.Controls.Add(this.majCombo3, 2, 0);
            this.majTable.Controls.Add(this.majCombo2, 1, 0);
            this.majTable.Controls.Add(this.majCombo1, 0, 0);
            this.majTable.Location = new System.Drawing.Point(126, 76);
            this.majTable.Name = "majTable";
            this.majTable.RowCount = 1;
            this.majTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.majTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.majTable.Size = new System.Drawing.Size(533, 35);
            this.majTable.TabIndex = 6;
            // 
            // majCombo5
            // 
            this.majCombo5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.majCombo5.FormattingEnabled = true;
            this.majCombo5.Location = new System.Drawing.Point(429, 7);
            this.majCombo5.Name = "majCombo5";
            this.majCombo5.Size = new System.Drawing.Size(99, 21);
            this.majCombo5.TabIndex = 4;
            // 
            // majCombo4
            // 
            this.majCombo4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.majCombo4.FormattingEnabled = true;
            this.majCombo4.Location = new System.Drawing.Point(322, 7);
            this.majCombo4.Name = "majCombo4";
            this.majCombo4.Size = new System.Drawing.Size(99, 21);
            this.majCombo4.TabIndex = 3;
            // 
            // majCombo3
            // 
            this.majCombo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.majCombo3.FormattingEnabled = true;
            this.majCombo3.Location = new System.Drawing.Point(216, 7);
            this.majCombo3.Name = "majCombo3";
            this.majCombo3.Size = new System.Drawing.Size(99, 21);
            this.majCombo3.TabIndex = 2;
            // 
            // majCombo2
            // 
            this.majCombo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.majCombo2.FormattingEnabled = true;
            this.majCombo2.Location = new System.Drawing.Point(110, 7);
            this.majCombo2.Name = "majCombo2";
            this.majCombo2.Size = new System.Drawing.Size(99, 21);
            this.majCombo2.TabIndex = 1;
            // 
            // majCombo1
            // 
            this.majCombo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.majCombo1.FormattingEnabled = true;
            this.majCombo1.Location = new System.Drawing.Point(4, 7);
            this.majCombo1.Name = "majCombo1";
            this.majCombo1.Size = new System.Drawing.Size(99, 21);
            this.majCombo1.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(333, 407);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(118, 23);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Create Button";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // attribsLabel
            // 
            this.attribsLabel.AutoSize = true;
            this.attribsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.attribsLabel.Location = new System.Drawing.Point(353, 175);
            this.attribsLabel.Name = "attribsLabel";
            this.attribsLabel.Size = new System.Drawing.Size(78, 20);
            this.attribsLabel.TabIndex = 11;
            this.attribsLabel.Text = "Attributes";
            // 
            // attribsTable
            // 
            this.attribsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.attribsTable.ColumnCount = 2;
            this.attribsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.attribsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.attribsTable.Controls.Add(this.attrCombo2, 0, 0);
            this.attribsTable.Controls.Add(this.attrCombo1, 0, 0);
            this.attribsTable.Location = new System.Drawing.Point(265, 198);
            this.attribsTable.Name = "attribsTable";
            this.attribsTable.RowCount = 1;
            this.attribsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.attribsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.attribsTable.Size = new System.Drawing.Size(256, 35);
            this.attribsTable.TabIndex = 12;
            // 
            // attrCombo2
            // 
            this.attrCombo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attrCombo2.FormattingEnabled = true;
            this.attrCombo2.Location = new System.Drawing.Point(142, 7);
            this.attrCombo2.Name = "attrCombo2";
            this.attrCombo2.Size = new System.Drawing.Size(99, 21);
            this.attrCombo2.TabIndex = 5;
            // 
            // attrCombo1
            // 
            this.attrCombo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attrCombo1.FormattingEnabled = true;
            this.attrCombo1.Location = new System.Drawing.Point(14, 7);
            this.attrCombo1.Name = "attrCombo1";
            this.attrCombo1.Size = new System.Drawing.Size(99, 21);
            this.attrCombo1.TabIndex = 3;
            // 
            // specLabel
            // 
            this.specLabel.AutoSize = true;
            this.specLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.specLabel.Location = new System.Drawing.Point(338, 236);
            this.specLabel.Name = "specLabel";
            this.specLabel.Size = new System.Drawing.Size(107, 20);
            this.specLabel.TabIndex = 13;
            this.specLabel.Text = "Specialization";
            // 
            // specTable
            // 
            this.specTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.specTable.ColumnCount = 1;
            this.specTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.specTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.specTable.Controls.Add(this.specCombo, 0, 0);
            this.specTable.Location = new System.Drawing.Point(338, 259);
            this.specTable.Name = "specTable";
            this.specTable.RowCount = 1;
            this.specTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.specTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.specTable.Size = new System.Drawing.Size(113, 35);
            this.specTable.TabIndex = 14;
            // 
            // specCombo
            // 
            this.specCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specCombo.FormattingEnabled = true;
            this.specCombo.Location = new System.Drawing.Point(7, 7);
            this.specCombo.Name = "specCombo";
            this.specCombo.Size = new System.Drawing.Size(99, 21);
            this.specCombo.TabIndex = 3;
            // 
            // classTextbox
            // 
            this.classTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classTextbox.Location = new System.Drawing.Point(123, 10);
            this.classTextbox.Name = "classTextbox";
            this.classTextbox.Size = new System.Drawing.Size(114, 20);
            this.classTextbox.TabIndex = 15;
            this.classTextbox.Text = "Adventurer";
            // 
            // classNameTable
            // 
            this.classNameTable.ColumnCount = 2;
            this.classNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classNameTable.Controls.Add(this.classTextbox, 1, 0);
            this.classNameTable.Controls.Add(this.classNameLab, 0, 0);
            this.classNameTable.Location = new System.Drawing.Point(265, 300);
            this.classNameTable.Name = "classNameTable";
            this.classNameTable.RowCount = 1;
            this.classNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classNameTable.Size = new System.Drawing.Size(240, 40);
            this.classNameTable.TabIndex = 16;
            // 
            // classNameLab
            // 
            this.classNameLab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.classNameLab.AutoSize = true;
            this.classNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classNameLab.Location = new System.Drawing.Point(19, 10);
            this.classNameLab.Name = "classNameLab";
            this.classNameLab.Size = new System.Drawing.Size(98, 20);
            this.classNameLab.TabIndex = 16;
            this.classNameLab.Text = "Class Name:";
            // 
            // descTable
            // 
            this.descTable.ColumnCount = 2;
            this.descTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.descTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.descTable.Controls.Add(this.descLabel, 0, 0);
            this.descTable.Controls.Add(this.descTextbox, 1, 0);
            this.descTable.Location = new System.Drawing.Point(126, 346);
            this.descTable.Name = "descTable";
            this.descTable.RowCount = 1;
            this.descTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.descTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.descTable.Size = new System.Drawing.Size(522, 50);
            this.descTable.TabIndex = 17;
            // 
            // descLabel
            // 
            this.descLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descLabel.Location = new System.Drawing.Point(165, 15);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(93, 20);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Description:";
            // 
            // descTextbox
            // 
            this.descTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTextbox.Location = new System.Drawing.Point(264, 3);
            this.descTextbox.Multiline = true;
            this.descTextbox.Name = "descTextbox";
            this.descTextbox.Size = new System.Drawing.Size(255, 44);
            this.descTextbox.TabIndex = 1;
            // 
            // CreateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 452);
            this.Controls.Add(this.descTable);
            this.Controls.Add(this.classNameTable);
            this.Controls.Add(this.specTable);
            this.Controls.Add(this.specLabel);
            this.Controls.Add(this.attribsTable);
            this.Controls.Add(this.attribsLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.minTable);
            this.Controls.Add(this.minLab);
            this.Controls.Add(this.majLab);
            this.Controls.Add(this.majTable);
            this.Controls.Add(this.topLabel);
            this.Name = "CreateClassForm";
            this.Text = "CreateClassForm";
            this.minTable.ResumeLayout(false);
            this.majTable.ResumeLayout(false);
            this.attribsTable.ResumeLayout(false);
            this.specTable.ResumeLayout(false);
            this.classNameTable.ResumeLayout(false);
            this.classNameTable.PerformLayout();
            this.descTable.ResumeLayout(false);
            this.descTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TableLayoutPanel minTable;
        private System.Windows.Forms.Label minLab;
        private System.Windows.Forms.Label majLab;
        private System.Windows.Forms.TableLayoutPanel majTable;
        private System.Windows.Forms.ComboBox majCombo5;
        private System.Windows.Forms.ComboBox majCombo4;
        private System.Windows.Forms.ComboBox majCombo3;
        private System.Windows.Forms.ComboBox majCombo2;
        private System.Windows.Forms.ComboBox majCombo1;
        private System.Windows.Forms.ComboBox minCombo4;
        private System.Windows.Forms.ComboBox minCombo5;
        private System.Windows.Forms.ComboBox minCombo3;
        private System.Windows.Forms.ComboBox minCombo1;
        private System.Windows.Forms.ComboBox minCombo2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label attribsLabel;
        private System.Windows.Forms.TableLayoutPanel attribsTable;
        private System.Windows.Forms.ComboBox attrCombo2;
        private System.Windows.Forms.ComboBox attrCombo1;
        private System.Windows.Forms.Label specLabel;
        private System.Windows.Forms.TableLayoutPanel specTable;
        private System.Windows.Forms.ComboBox specCombo;
        private System.Windows.Forms.TextBox classTextbox;
        private System.Windows.Forms.TableLayoutPanel classNameTable;
        private System.Windows.Forms.Label classNameLab;
        private System.Windows.Forms.TableLayoutPanel descTable;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox descTextbox;
    }
}