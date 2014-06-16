namespace MazumaBot
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mazumaPricesDtaGrdVw = new System.Windows.Forms.DataGridView();
            this.manufacturerClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionClm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.valueClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mazumaPricesDtaGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mazumaPricesDtaGrdVw);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Latest Mazuma Prices";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(746, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "eBay Auctions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(746, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mazumaPricesDtaGrdVw
            // 
            this.mazumaPricesDtaGrdVw.AllowUserToAddRows = false;
            this.mazumaPricesDtaGrdVw.AllowUserToDeleteRows = false;
            this.mazumaPricesDtaGrdVw.AllowUserToResizeColumns = false;
            this.mazumaPricesDtaGrdVw.AllowUserToResizeRows = false;
            this.mazumaPricesDtaGrdVw.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mazumaPricesDtaGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mazumaPricesDtaGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerClm,
            this.modelClm,
            this.conditionClm,
            this.valueClm});
            this.mazumaPricesDtaGrdVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mazumaPricesDtaGrdVw.Location = new System.Drawing.Point(3, 3);
            this.mazumaPricesDtaGrdVw.Name = "mazumaPricesDtaGrdVw";
            this.mazumaPricesDtaGrdVw.ReadOnly = true;
            this.mazumaPricesDtaGrdVw.RowHeadersVisible = false;
            this.mazumaPricesDtaGrdVw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mazumaPricesDtaGrdVw.Size = new System.Drawing.Size(740, 360);
            this.mazumaPricesDtaGrdVw.TabIndex = 0;
            // 
            // manufacturerClm
            // 
            this.manufacturerClm.HeaderText = "Manufacturer";
            this.manufacturerClm.Name = "manufacturerClm";
            this.manufacturerClm.ReadOnly = true;
            this.manufacturerClm.Width = 200;
            // 
            // modelClm
            // 
            this.modelClm.HeaderText = "Model";
            this.modelClm.Name = "modelClm";
            this.modelClm.ReadOnly = true;
            this.modelClm.Width = 300;
            // 
            // conditionClm
            // 
            this.conditionClm.HeaderText = "Condition";
            this.conditionClm.Name = "conditionClm";
            this.conditionClm.ReadOnly = true;
            this.conditionClm.Width = 150;
            // 
            // valueClm
            // 
            this.valueClm.HeaderText = "Value";
            this.valueClm.Name = "valueClm";
            this.valueClm.ReadOnly = true;
            this.valueClm.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mazuma Bot";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mazumaPricesDtaGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView mazumaPricesDtaGrdVw;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelClm;
        private System.Windows.Forms.DataGridViewComboBoxColumn conditionClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueClm;
    }
}

