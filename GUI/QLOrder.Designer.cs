namespace WindowsFormsApp1
{
    partial class QLOrder
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
            txtMaTTDH = new TextBox();
            txtMoTa = new TextBox();
            txtTenTT = new TextBox();
            btnImportDH = new Button();
            btnExportDH = new Button();
            btnXoaDH = new Button();
            btnSuaDH = new Button();
            btnNhapDH = new Button();
            btnRefreshDH = new Button();
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
            dgvDH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvDH.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDH.Columns.AddRange(new DataGridViewColumn[] { maTrangThaiDonHang, tenTrangThai, moTa });
            dgvDH.Location = new Point(3, 4);
            dgvDH.Margin = new Padding(3, 4, 3, 4);
            dgvDH.Name = "dgvDH";
            dgvDH.RowHeadersWidth = 82;
            dgvDH.RowTemplate.Height = 33;
            dgvDH.Size = new Size(1360, 682);
            dgvDH.TabIndex = 1;
            dgvDH.DataBindingComplete += dgvDH_DataBindingComplete;
            dgvDH.SelectionChanged += dgvDH_SelectionChanged;
            // 
            // maTrangThaiDonHang
            // 
            maTrangThaiDonHang.DataPropertyName = "MaTrangThaiDonHang";
            maTrangThaiDonHang.HeaderText = "Mã Trạng Thái Đơn Hàng";
            maTrangThaiDonHang.MinimumWidth = 10;
            maTrangThaiDonHang.Name = "maTrangThaiDonHang";
            // 
            // tenTrangThai
            // 
            tenTrangThai.DataPropertyName = "TenTrangThai";
            tenTrangThai.HeaderText = "Tên Trạng Thái ";
            tenTrangThai.MinimumWidth = 10;
            tenTrangThai.Name = "tenTrangThai";
            // 
            // moTa
            // 
            moTa.DataPropertyName = "MoTa";
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
            label2.Size = new Size(82, 32);
            label2.TabIndex = 2;
            label2.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 806);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 3;
            label3.Text = "Tên trạng thái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 724);
            label4.Name = "label4";
            label4.Size = new Size(280, 32);
            label4.TabIndex = 4;
            label4.Text = "Mã trạng thái đơn hàng: ";
            // 
            // txtMaTTDH
            // 
            txtMaTTDH.Location = new Point(360, 724);
            txtMaTTDH.Margin = new Padding(3, 4, 3, 4);
            txtMaTTDH.Name = "txtMaTTDH";
            txtMaTTDH.Size = new Size(269, 39);
            txtMaTTDH.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(196, 891);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(433, 39);
            txtMoTa.TabIndex = 6;
            // 
            // txtTenTT
            // 
            txtTenTT.Location = new Point(247, 806);
            txtTenTT.Margin = new Padding(3, 4, 3, 4);
            txtTenTT.Name = "txtTenTT";
            txtTenTT.Size = new Size(382, 39);
            txtTenTT.TabIndex = 7;
            // 
            // btnImportDH
            // 
            btnImportDH.BackColor = Color.AliceBlue;
            btnImportDH.Location = new Point(1202, 849);
            btnImportDH.Margin = new Padding(3, 4, 3, 4);
            btnImportDH.Name = "btnImportDH";
            btnImportDH.Size = new Size(129, 74);
            btnImportDH.TabIndex = 68;
            btnImportDH.Text = "Import";
            btnImportDH.UseVisualStyleBackColor = false;
            btnImportDH.Click += btnImportDH_Click;
            // 
            // btnExportDH
            // 
            btnExportDH.BackColor = Color.AliceBlue;
            btnExportDH.Location = new Point(980, 849);
            btnExportDH.Margin = new Padding(3, 4, 3, 4);
            btnExportDH.Name = "btnExportDH";
            btnExportDH.Size = new Size(129, 74);
            btnExportDH.TabIndex = 67;
            btnExportDH.Text = "Export";
            btnExportDH.UseVisualStyleBackColor = false;
            btnExportDH.Click += btnExportDH_Click;
            // 
            // btnXoaDH
            // 
            btnXoaDH.BackColor = Color.Lavender;
            btnXoaDH.Location = new Point(1202, 724);
            btnXoaDH.Margin = new Padding(3, 4, 3, 4);
            btnXoaDH.Name = "btnXoaDH";
            btnXoaDH.Size = new Size(129, 72);
            btnXoaDH.TabIndex = 66;
            btnXoaDH.Text = "Xóa";
            btnXoaDH.UseVisualStyleBackColor = false;
            btnXoaDH.Click += btnXoaDH_Click;
            // 
            // btnSuaDH
            // 
            btnSuaDH.BackColor = Color.Lavender;
            btnSuaDH.Location = new Point(980, 724);
            btnSuaDH.Margin = new Padding(3, 4, 3, 4);
            btnSuaDH.Name = "btnSuaDH";
            btnSuaDH.Size = new Size(129, 72);
            btnSuaDH.TabIndex = 65;
            btnSuaDH.Text = "Sửa";
            btnSuaDH.UseVisualStyleBackColor = false;
            btnSuaDH.Click += btnSuaDH_Click;
            // 
            // btnNhapDH
            // 
            btnNhapDH.BackColor = Color.LightSlateGray;
            btnNhapDH.ForeColor = SystemColors.ButtonHighlight;
            btnNhapDH.Location = new Point(759, 724);
            btnNhapDH.Margin = new Padding(3, 4, 3, 4);
            btnNhapDH.Name = "btnNhapDH";
            btnNhapDH.Size = new Size(136, 72);
            btnNhapDH.TabIndex = 69;
            btnNhapDH.Text = "Nhập";
            btnNhapDH.UseVisualStyleBackColor = false;
            btnNhapDH.Click += btnNhapDH_Click;
            // 
            // btnRefreshDH
            // 
            btnRefreshDH.BackColor = SystemColors.Highlight;
            btnRefreshDH.ForeColor = SystemColors.ButtonHighlight;
            btnRefreshDH.Location = new Point(766, 849);
            btnRefreshDH.Margin = new Padding(3, 4, 3, 4);
            btnRefreshDH.Name = "btnRefreshDH";
            btnRefreshDH.Size = new Size(129, 74);
            btnRefreshDH.TabIndex = 72;
            btnRefreshDH.Text = "Refresh";
            btnRefreshDH.UseVisualStyleBackColor = false;
            btnRefreshDH.Click += btnRefreshDH_Click;
            // 
            // QLOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefreshDH);
            Controls.Add(btnNhapDH);
            Controls.Add(btnImportDH);
            Controls.Add(btnExportDH);
            Controls.Add(btnXoaDH);
            Controls.Add(btnSuaDH);
            Controls.Add(txtTenTT);
            Controls.Add(txtMoTa);
            Controls.Add(txtMaTTDH);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QLOrder";
            Size = new Size(1369, 966);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDH;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaTTDH;
        private TextBox txtMoTa;
        private TextBox txtTenTT;
        private Button btnImportDH;
        private Button btnExportDH;
        private Button btnXoaDH;
        private Button btnSuaDH;
        private Button btnNhapDH;
        private DataGridViewTextBoxColumn maTrangThaiDonHang;
        private DataGridViewTextBoxColumn tenTrangThai;
        private DataGridViewTextBoxColumn moTa;
        private Button btnRefreshDH;
    }
}
