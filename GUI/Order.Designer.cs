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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvDH = new DataGridView();
            maTrangThaiDonHang = new DataGridViewTextBoxColumn();
            tenTrangThai = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnImport = new Button();
            btnExport = new Button();
            btnXoaNV = new Button();
            btnSuaNV = new Button();
            btnNhapNV = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDH).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvDH, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1388, 690);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDH
            // 
            dgvDH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDH.BackgroundColor = SystemColors.Control;
            dgvDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDH.Columns.AddRange(new DataGridViewColumn[] { maTrangThaiDonHang, tenTrangThai, moTa });
            dgvDH.Location = new Point(3, 4);
            dgvDH.Margin = new Padding(3, 4, 3, 4);
            dgvDH.Name = "dgvDH";
            dgvDH.RowHeadersWidth = 82;
            dgvDH.RowTemplate.Height = 33;
            dgvDH.Size = new Size(1360, 682);
            dgvDH.TabIndex = 1;
            // 
            // maTrangThaiDonHang
            // 
            maTrangThaiDonHang.HeaderText = "Mã Trạng Thái Đơn Hàng";
            maTrangThaiDonHang.MinimumWidth = 10;
            maTrangThaiDonHang.Name = "maTrangThaiDonHang";
            // 
            // tenTrangThai
            // 
            tenTrangThai.HeaderText = "Tên Trạng Thái ";
            tenTrangThai.MinimumWidth = 10;
            tenTrangThai.Name = "tenTrangThai";
            // 
            // moTa
            // 
            moTa.HeaderText = "Mô Tả";
            moTa.MinimumWidth = 10;
            moTa.Name = "moTa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 475);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 891);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 806);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 724);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 724);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 891);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 806);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(433, 39);
            textBox3.TabIndex = 7;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.AliceBlue;
            btnImport.Location = new Point(973, 856);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(136, 74);
            btnImport.TabIndex = 68;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.AliceBlue;
            btnExport.Location = new Point(747, 856);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(136, 74);
            btnExport.TabIndex = 67;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnXoaNV
            // 
            btnXoaNV.BackColor = Color.Lavender;
            btnXoaNV.Location = new Point(1219, 724);
            btnXoaNV.Margin = new Padding(3, 4, 3, 4);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(129, 72);
            btnXoaNV.TabIndex = 66;
            btnXoaNV.Text = "Xóa";
            btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // btnSuaNV
            // 
            btnSuaNV.BackColor = Color.Lavender;
            btnSuaNV.Location = new Point(980, 724);
            btnSuaNV.Margin = new Padding(3, 4, 3, 4);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(129, 72);
            btnSuaNV.TabIndex = 65;
            btnSuaNV.Text = "Sửa";
            btnSuaNV.UseVisualStyleBackColor = false;
            // 
            // btnNhapNV
            // 
            btnNhapNV.BackColor = Color.LightSlateGray;
            btnNhapNV.ForeColor = SystemColors.ButtonHighlight;
            btnNhapNV.Location = new Point(747, 724);
            btnNhapNV.Margin = new Padding(3, 4, 3, 4);
            btnNhapNV.Name = "btnNhapNV";
            btnNhapNV.Size = new Size(136, 72);
            btnNhapNV.TabIndex = 69;
            btnNhapNV.Text = "Nhập";
            btnNhapNV.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNhapNV);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnXoaNV);
            Controls.Add(btnSuaNV);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Order";
            Size = new Size(1369, 966);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDH;
        private DataGridViewTextBoxColumn maTrangThaiDonHang;
        private DataGridViewTextBoxColumn tenTrangThai;
        private DataGridViewTextBoxColumn moTa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnImport;
        private Button btnExport;
        private Button btnXoaNV;
        private Button btnSuaNV;
        private Button btnNhapNV;
    }
}
