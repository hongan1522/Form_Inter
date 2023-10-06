namespace WindowsFormsApp1
{
    partial class Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.maTrangThaiDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnNhapNV = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDH, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1118, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDH
            // 
            this.dgvDH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTrangThaiDonHang,
            this.tenTrangThai,
            this.moTa});
            this.dgvDH.Location = new System.Drawing.Point(3, 3);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.RowHeadersWidth = 82;
            this.dgvDH.RowTemplate.Height = 33;
            this.dgvDH.Size = new System.Drawing.Size(1102, 399);
            this.dgvDH.TabIndex = 1;
            // 
            // maTrangThaiDonHang
            // 
            this.maTrangThaiDonHang.HeaderText = "Mã Trạng Thái Đơn Hàng";
            this.maTrangThaiDonHang.MinimumWidth = 10;
            this.maTrangThaiDonHang.Name = "maTrangThaiDonHang";
            // 
            // tenTrangThai
            // 
            this.tenTrangThai.HeaderText = "Tên Trạng Thái ";
            this.tenTrangThai.MinimumWidth = 10;
            this.tenTrangThai.Name = "tenTrangThai";
            // 
            // moTa
            // 
            this.moTa.HeaderText = "Mô Tả";
            this.moTa.MinimumWidth = 10;
            this.moTa.Name = "moTa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 31);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 552);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 31);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 485);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 31);
            this.textBox3.TabIndex = 7;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnImport.Location = new System.Drawing.Point(924, 579);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(126, 48);
            this.btnImport.TabIndex = 68;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExport.Location = new System.Drawing.Point(703, 579);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 48);
            this.btnExport.TabIndex = 67;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Lavender;
            this.btnXoaNV.Location = new System.Drawing.Point(924, 495);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(119, 48);
            this.btnXoaNV.TabIndex = 66;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.Lavender;
            this.btnSuaNV.Location = new System.Drawing.Point(703, 495);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(119, 48);
            this.btnSuaNV.TabIndex = 65;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            // 
            // btnNhapNV
            // 
            this.btnNhapNV.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNhapNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapNV.Location = new System.Drawing.Point(808, 414);
            this.btnNhapNV.Name = "btnNhapNV";
            this.btnNhapNV.Size = new System.Drawing.Size(126, 56);
            this.btnNhapNV.TabIndex = 69;
            this.btnNhapNV.Text = "Nhập";
            this.btnNhapNV.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNhapNV);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1124, 643);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrangThaiDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnNhapNV;
    }
}
