namespace Gold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbl_TuNgay = new System.Windows.Forms.Label();
            this.tbl_DenNgay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtb_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_TuNgay
            // 
            this.tbl_TuNgay.AutoSize = true;
            this.tbl_TuNgay.Location = new System.Drawing.Point(33, 37);
            this.tbl_TuNgay.Name = "tbl_TuNgay";
            this.tbl_TuNgay.Size = new System.Drawing.Size(48, 13);
            this.tbl_TuNgay.TabIndex = 2;
            this.tbl_TuNgay.Text = "Từ Ngày";
            this.tbl_TuNgay.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbl_DenNgay
            // 
            this.tbl_DenNgay.AutoSize = true;
            this.tbl_DenNgay.Location = new System.Drawing.Point(341, 37);
            this.tbl_DenNgay.Name = "tbl_DenNgay";
            this.tbl_DenNgay.Size = new System.Drawing.Size(55, 13);
            this.tbl_DenNgay.TabIndex = 2;
            this.tbl_DenNgay.Text = "Đến Ngày";
            this.tbl_DenNgay.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtb_DenNgay);
            this.panel1.Controls.Add(this.dtp_TuNgay);
            this.panel1.Controls.Add(this.tbl_DenNgay);
            this.panel1.Controls.Add(this.tbl_TuNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 69);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtb_DenNgay
            // 
            this.dtb_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_DenNgay.Location = new System.Drawing.Point(419, 31);
            this.dtb_DenNgay.Name = "dtb_DenNgay";
            this.dtb_DenNgay.Size = new System.Drawing.Size(116, 20);
            this.dtb_DenNgay.TabIndex = 3;
            this.dtb_DenNgay.Value = new System.DateTime(2015, 9, 20, 0, 0, 0, 0);
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(92, 31);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(103, 20);
            this.dtp_TuNgay.TabIndex = 3;
            this.dtp_TuNgay.Value = new System.DateTime(2015, 9, 20, 14, 44, 25, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 192);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoldRate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tbl_TuNgay;
        private System.Windows.Forms.Label tbl_DenNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtb_DenNgay;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}

