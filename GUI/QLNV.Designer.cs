namespace WindowsFormsApp1
{
    partial class QLNV
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
            dgvNV = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            label6 = new Label();
            txtDC = new TextBox();
            label5 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            dtpNS = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtTenNV = new TextBox();
            label1 = new Label();
            txtMaNV = new TextBox();
            btnImport = new Button();
            btnExport = new Button();
            btnNhapNV = new Button();
            btnXoaNV = new Button();
            btnSuaNV = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvNV, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.19618F));
            tableLayoutPanel1.Size = new Size(1383, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvNV
            // 
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNV.BackgroundColor = SystemColors.ControlLightLight;
            dgvNV.ColumnHeadersHeight = 46;
            dgvNV.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, NgaySinh, SDT, Email, DiaChi });
            dgvNV.Dock = DockStyle.Fill;
            dgvNV.Location = new Point(3, 4);
            dgvNV.Margin = new Padding(3, 4, 3, 4);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 82;
            dgvNV.RowTemplate.Height = 33;
            dgvNV.Size = new Size(1377, 622);
            dgvNV.TabIndex = 1;
            dgvNV.DataBindingComplete += dgvNV_DataBindingComplete;
            dgvNV.SelectionChanged += dgvNV_SelectionChanged;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNhanVien";
            MaNV.FillWeight = 61.66808F;
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 10;
            MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNhanVien";
            TenNV.FillWeight = 124.1778F;
            TenNV.HeaderText = "Tên NV";
            TenNV.MinimumWidth = 10;
            TenNV.Name = "TenNV";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.FillWeight = 139.3108F;
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 10;
            NgaySinh.Name = "NgaySinh";
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.FillWeight = 83.46929F;
            SDT.HeaderText = "SĐT";
            SDT.MinimumWidth = 10;
            SDT.Name = "SDT";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.FillWeight = 90.85173F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 100.5223F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Highlight;
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(965, 857);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 72);
            btnRefresh.TabIndex = 71;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(673, 788);
            label6.Name = "label6";
            label6.Size = new Size(88, 24);
            label6.TabIndex = 70;
            label6.Text = "Địa Chỉ:";
            // 
            // txtDC
            // 
            txtDC.Location = new Point(865, 779);
            txtDC.Margin = new Padding(3, 4, 3, 4);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(432, 39);
            txtDC.TabIndex = 59;
            txtDC.KeyDown += QLNV_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(673, 731);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 69;
            label5.Text = "SĐT:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(865, 722);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(432, 39);
            txtSDT.TabIndex = 58;
            txtSDT.KeyDown += QLNV_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(673, 673);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 68;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(865, 667);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(432, 39);
            txtEmail.TabIndex = 57;
            txtEmail.KeyDown += QLNV_KeyDown;
            // 
            // dtpNS
            // 
            dtpNS.Checked = false;
            dtpNS.CustomFormat = "dd/MM/yyyy";
            dtpNS.Format = DateTimePickerFormat.Custom;
            dtpNS.Location = new Point(223, 777);
            dtpNS.Margin = new Padding(3, 4, 3, 4);
            dtpNS.Name = "dtpNS";
            dtpNS.Size = new Size(299, 39);
            dtpNS.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 777);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 67;
            label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 724);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 66;
            label2.Text = "Tên NV:";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(223, 724);
            txtTenNV.Margin = new Padding(3, 4, 3, 4);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(299, 39);
            txtTenNV.TabIndex = 55;
            txtTenNV.KeyDown += QLNV_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 677);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 65;
            label1.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(223, 663);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(299, 39);
            txtMaNV.TabIndex = 54;
            txtMaNV.KeyDown += QLNV_KeyDown;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.AliceBlue;
            btnImport.Location = new Point(721, 857);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(136, 72);
            btnImport.TabIndex = 64;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.AliceBlue;
            btnExport.Location = new Point(487, 857);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(136, 72);
            btnExport.TabIndex = 63;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnNhapNV
            // 
            btnNhapNV.BackColor = Color.LightSlateGray;
            btnNhapNV.ForeColor = SystemColors.ButtonHighlight;
            btnNhapNV.Location = new Point(1189, 857);
            btnNhapNV.Margin = new Padding(3, 4, 3, 4);
            btnNhapNV.Name = "btnNhapNV";
            btnNhapNV.Size = new Size(136, 72);
            btnNhapNV.TabIndex = 60;
            btnNhapNV.Text = "Nhập";
            btnNhapNV.UseVisualStyleBackColor = false;
            btnNhapNV.Click += btnNhapNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.BackColor = Color.Lavender;
            btnXoaNV.Location = new Point(259, 857);
            btnXoaNV.Margin = new Padding(3, 4, 3, 4);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(129, 72);
            btnXoaNV.TabIndex = 62;
            btnXoaNV.Text = "Xóa";
            btnXoaNV.UseVisualStyleBackColor = false;
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // btnSuaNV
            // 
            btnSuaNV.BackColor = Color.Lavender;
            btnSuaNV.Location = new Point(43, 857);
            btnSuaNV.Margin = new Padding(3, 4, 3, 4);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(129, 72);
            btnSuaNV.TabIndex = 61;
            btnSuaNV.Text = "Sửa";
            btnSuaNV.UseVisualStyleBackColor = false;
            btnSuaNV.Click += btnSuaNV_Click;
            // 
            // QLNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(label6);
            Controls.Add(txtDC);
            Controls.Add(label5);
            Controls.Add(txtSDT);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(dtpNS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenNV);
            Controls.Add(label1);
            Controls.Add(txtMaNV);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnNhapNV);
            Controls.Add(btnXoaNV);
            Controls.Add(btnSuaNV);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QLNV";
            Size = new Size(1395, 969);
            Load += QLNV_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvNV;
        private Button btnRefresh;
        private Label label6;
        private TextBox txtDC;
        private Label label5;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtEmail;
        private DateTimePicker dtpNS;
        private Label label3;
        private Label label2;
        private TextBox txtTenNV;
        private Label label1;
        private TextBox txtMaNV;
        private Button btnImport;
        private Button btnExport;
        private Button btnNhapNV;
        private Button btnXoaNV;
        private Button btnSuaNV;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
