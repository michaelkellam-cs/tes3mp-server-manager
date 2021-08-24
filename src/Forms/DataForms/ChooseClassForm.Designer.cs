namespace TES3MP_GUI.src.Forms.DataForms
{
    partial class ChooseClassForm
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
            this.choiceLabel = new System.Windows.Forms.Label();
            this.customBtn = new System.Windows.Forms.Button();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnsTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.choiceLabel.Location = new System.Drawing.Point(99, 9);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(233, 25);
            this.choiceLabel.TabIndex = 0;
            this.choiceLabel.Text = "Please choose class type";
            // 
            // customBtn
            // 
            this.customBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customBtn.Location = new System.Drawing.Point(31, 4);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(75, 23);
            this.customBtn.TabIndex = 1;
            this.customBtn.Text = "Custom";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // defaultBtn
            // 
            this.defaultBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defaultBtn.Location = new System.Drawing.Point(169, 4);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(75, 23);
            this.defaultBtn.TabIndex = 2;
            this.defaultBtn.Text = "Default";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.Location = new System.Drawing.Point(307, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnsTable
            // 
            this.btnsTable.ColumnCount = 3;
            this.btnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnsTable.Controls.Add(this.customBtn, 0, 0);
            this.btnsTable.Controls.Add(this.cancelBtn, 2, 0);
            this.btnsTable.Controls.Add(this.defaultBtn, 1, 0);
            this.btnsTable.Location = new System.Drawing.Point(12, 61);
            this.btnsTable.Name = "btnsTable";
            this.btnsTable.RowCount = 1;
            this.btnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btnsTable.Size = new System.Drawing.Size(414, 31);
            this.btnsTable.TabIndex = 4;
            // 
            // ChooseClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 104);
            this.Controls.Add(this.btnsTable);
            this.Controls.Add(this.choiceLabel);
            this.Name = "ChooseClassForm";
            this.Text = "ChooseClassForm";
            this.btnsTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button defaultBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel btnsTable;
    }
}