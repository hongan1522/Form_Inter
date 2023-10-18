using BLL;
using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Label = System.Windows.Forms.Label;

namespace GUI
{
    public partial class uc_NhanVien : UserControl
    {
        private TableLayoutPanel tlp_ucNV = new TableLayoutPanel();
        private DataGridView dgvNV = new DataGridView();
        private TextBox txtMaNhanVien = new TextBox();
        private TextBox txtTenNhanVien = new TextBox();
        private TextBox txtEmail = new TextBox();
        private TextBox txtsdt = new TextBox();
        private TextBox txtDC = new TextBox();
        private DateTimePicker dtpNgaySinh = new DateTimePicker();
        private Label lbMa = new Label();
        private Label lbTen = new Label();
        private Label lbNS = new Label();
        private Label lbEmail = new Label();
        private Label lbSDT = new Label();
        private Label lbDiaChi = new Label();
        private Button btnAdd = new Button();
        private Button btnUpdate = new Button();
        private Button btnDelete = new Button();
        public Button btnRefresh = new Button();
        private Button btnImport = new Button();
        private Button btnExport = new Button();

        private readonly QuanLy_BLL bllNV = new QuanLy_BLL();
        private List<NhanVien>? listNV;
        public uc_NhanVien()
        {
            InitializeComponent();
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.AutoGenerateColumns = false;

            //
            //  tlp_ucNV
            //
            Controls.Add(tlp_ucNV);
            tlp_ucNV.Controls.Add(dgvNV, 0, 0);
            tlp_ucNV.Location = new Point(0, 0);
            tlp_ucNV.Margin = new Padding(3, 4, 3, 4);
            tlp_ucNV.Name = "tlp_ucNV";
            tlp_ucNV.RowCount = 1;
            tlp_ucNV.Size = new Size(1383, 630);
            tlp_ucNV.TabIndex = 0;
            tlp_ucNV.Dock = DockStyle.Top;
            tlp_ucNV.SetColumnSpan(dgvNV, 6);
            //
            //  dgvNV
            //
            DataGridViewTextBoxColumn MaNhanVien = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TenNhanVien = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SDT = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();

            dgvNV.Dock = DockStyle.Fill;
            dgvNV.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, NgaySinh, Email, SDT, DiaChi });
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNV.SelectionChanged += dgvNV_SelectionChanged;
            //
            //  MaNhanVien
            //
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.Name = "MaNV";
            //
            //  TenNhanVien
            //
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.Name = "TenNV";
            //
            //  NgaySinh
            //
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.Name = "NgaySinh";
            //
            //  Email
            //
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            //
            //  SDT
            //
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "SĐT";
            SDT.Name = "SDT";
            //
            //  DiaChi
            //
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            //
            //  txtMaNhanVien
            //
            txtMaNhanVien.Location = new Point(223, 669);
            txtMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(280, 39);
            txtMaNhanVien.TabIndex = 1;
            Controls.Add(txtMaNhanVien);
            //
            //  txtTenNhanVien
            //
            txtTenNhanVien.Location = new Point(223, 724);
            txtTenNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(280, 39);
            txtTenNhanVien.TabIndex = 2;
            Controls.Add(txtTenNhanVien);
            //
            //  txtEmail
            //
            txtEmail.Location = new Point(750, 669);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 39);
            txtEmail.TabIndex = 3;
            Controls.Add(txtEmail);
            //
            //  txtsdt
            //
            txtsdt.Location = new Point(750, 724);
            txtsdt.Margin = new Padding(3, 4, 3, 4);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(280, 39);
            txtsdt.TabIndex = 4;
            Controls.Add(txtsdt);
            //
            //  txtDC
            //
            txtDC.Location = new Point(750, 781);
            txtDC.Margin = new Padding(3, 4, 3, 4);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(280, 80);
            txtDC.Multiline = true;
            txtDC.TabIndex = 5;
            Controls.Add(txtDC);
            //
            //  dtpNgaySinh
            //
            dtpNgaySinh.Checked = false;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(223, 777);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(280, 39);
            dtpNgaySinh.TabIndex = 6;
            Controls.Add(dtpNgaySinh);
            //
            //  lbDiaChi
            //
            Controls.Add(lbDiaChi);
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDiaChi.Location = new Point(600, 790);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(88, 24);
            lbDiaChi.TabIndex = 70;
            lbDiaChi.Text = "Địa Chỉ:";
            //
            //  lbSDT
            //
            Controls.Add(lbSDT);
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSDT.Location = new Point(600, 733);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(57, 24);
            lbSDT.TabIndex = 69;
            lbSDT.Text = "SĐT:";
            //
            //  lbEmail
            //
            Controls.Add(lbEmail);
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(600, 675);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(72, 24);
            lbEmail.TabIndex = 68;
            lbEmail.Text = "Email:";
            //
            //  lbNS
            //
            Controls.Add(lbNS);
            lbNS.AutoSize = true;
            lbNS.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNS.Location = new Point(43, 777);
            lbNS.Name = "lbNS";
            lbNS.Size = new Size(127, 25);
            lbNS.TabIndex = 67;
            lbNS.Text = "Ngày Sinh:";
            //
            //  lbTen
            //
            Controls.Add(lbTen);
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTen.Location = new Point(43, 724);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(97, 25);
            lbTen.TabIndex = 66;
            lbTen.Text = "Tên NV:";
            //
            //  lbMa
            //
            Controls.Add(lbMa);
            lbMa.AutoSize = true;
            lbMa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMa.Location = new Point(49, 677);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(89, 25);
            lbMa.TabIndex = 65;
            lbMa.Text = "Mã NV:";
            //
            //  btnAdd
            //
            btnAdd.Location = new Point(1100, 662);
            btnAdd.BackColor = Color.Tan;
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            Controls.Add(btnAdd);
            //
            //  btnRefresh
            //
            btnRefresh.Location = new Point(1300, 662);
            btnRefresh.BackColor = Color.Tan;
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            Controls.Add(btnRefresh);
            // 
            // btnImport
            // 
            Controls.Add(btnImport);
            btnImport.BackColor = Color.DarkSeaGreen;
            btnImport.Location = new Point(1300, 805);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(150, 46);
            btnImport.TabIndex = 64;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += BtnImport_Click;
            // 
            // btnExport
            // 
            Controls.Add(btnExport);
            btnExport.BackColor = Color.DarkSeaGreen;
            btnExport.Location = new Point(1100, 805);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 46);
            btnExport.TabIndex = 64;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += BtnExport_Click;
            // 
            // btnUpdate
            // 
            Controls.Add(btnUpdate);
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1100, 735);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 64;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            Controls.Add(btnDelete);
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1300, 735);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 64;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;

            AddDataSample();
            LoadListNV();
        }
        public bool IsMaNVValidAndNotDuplicate(NhanVien nhanVien)
        {
            // Kiểm tra Mã nhân viên không được null hoặc rỗng
            if (string.IsNullOrEmpty(nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên không được rỗng.");
                return false;
            }

            // Kiểm tra xem MaNV có đúng định dạng không
            Regex regex = new(@"^NV\d+$");
            if (!regex.IsMatch(nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng nhập đúng định dạng (vd: NV1, NV2,....)");
                return false;
            }

            // Kiểm tra xem MaNV đã tồn tại trong danh sách nhân viên chưa
            foreach (NhanVien nv in listNV)
            {
                if (nv.MaNhanVien == nhanVien.MaNhanVien)
                {
                    return false;
                }
            }

            return true;
        }
        private string GenerateUniqueMaNV(List<string> existingMaNV, string baseCode)
        {
            int maxMaNV = 0;

            foreach (string code in existingMaNV)
            {
                if (int.TryParse(code.Substring(2), out int ma))
                {
                    maxMaNV = Math.Max(maxMaNV, ma);
                }
            }

            return baseCode + (maxMaNV + 1);
        }
        public bool IsNVValid(NhanVien nv)
        {
            // Kiểm tra null hoặc không phải chuỗi số
            if (string.IsNullOrEmpty(nv.SDT) || !nv.SDT.All(char.IsDigit))
            {
                return false;
            }

            // Kiểm tra bắt đầu từ số 0 và có đúng 10 chữ số
            if (!(nv.SDT.Length == 10 && nv.SDT.StartsWith("0")))
            {
                return false;
            }

            // Kiểm tra email hợp lệ
            try
            {
                var addr = new System.Net.Mail.MailAddress(nv.Email);
                if (addr.Address != nv.Email)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            // Kiểm tra ngày sinh
            if (nv.NgaySinh >= DateTime.Now)
            {
                return false;
            }

            return true;
        }
        public bool IsPhoneNumberDuplicate(NhanVien nv)
        {
            foreach (NhanVien existingNV in listNV)
            {
                if (existingNV.SDT == nv.SDT)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsEmailDuplicate(NhanVien nv)
        {
            foreach (NhanVien existingNV in listNV)
            {
                if (existingNV.Email == nv.Email)
                {
                    return true;
                }
            }
            return false;
        }
        private void LoadListNV()
        {
            listNV = bllNV.GetListNV();
            dgvNV.DataSource = null;
            dgvNV.DataSource = listNV;
        }
        private void Clear()
        {
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Clear();
            txtsdt.Clear();
            txtDC.Clear();
        }
        private void AddDataSample()
        {
            dgvNV.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            List<NhanVien> listNVMau = new()
            {
                new NhanVien()
                {
                    MaNhanVien = "NV1",
                    TenNhanVien = "Nguyễn Văn A",
                    NgaySinh = new DateTime(1990, 10, 01),
                    Email = "nguyenvana@gmail.com",
                    SDT = "0111111111",
                    DiaChi = "123 Đường ABC, Quận ABC, TPHCM"
                },
                new NhanVien()
                {
                    MaNhanVien = "NV2",
                    TenNhanVien = "Trần Thị B",
                    NgaySinh = new DateTime(1995, 5, 20),
                    Email = "tranthib@gmail.com",
                    SDT = "0111111112",
                    DiaChi = "456 Đường DEF, Quận DEF, TPHCM"
                },
                new NhanVien()
                {
                    MaNhanVien = "NV3",
                    TenNhanVien = "Phạm Nguyễn Thị C",
                    NgaySinh = new DateTime(1988, 8, 8),
                    Email = "phamnguyenthic@gmail.com",
                    SDT = "0111111113",
                    DiaChi = "789 Đường GHI, Quận GHI, TPHCM"
                },
                new NhanVien()
                {
                    MaNhanVien = "NV4",
                    TenNhanVien = "Võ Lê Văn D",
                    NgaySinh = new DateTime(1993, 3, 10),
                    Email = "volevand@gmail.com",
                    SDT = "0111111114",
                    DiaChi = "111 Đường XYZ, Quận ZYZ, TPHCM"
                }
            };

            foreach (NhanVien nhanVienMau in listNVMau)
            {
                bllNV.AddNV(nhanVienMau);
            }

            LoadListNV();
            Clear();

        }
        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNV.CurrentRow;
            if (dr != null)
            {
                txtMaNhanVien.Text = (dr.Cells["MaNV"].Value ?? string.Empty).ToString();
                txtTenNhanVien.Text = (dr.Cells["TenNV"].Value ?? string.Empty).ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dr.Cells["NgaySinh"].Value ?? DateTime.Now);
                txtEmail.Text = (dr.Cells["Email"].Value ?? string.Empty).ToString();
                txtsdt.Text = (dr.Cells["SDT"].Value ?? string.Empty).ToString();
                txtDC.Text = (dr.Cells["DiaChi"].Value ?? string.Empty).ToString();
            }
            txtMaNhanVien.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            NhanVien nv = new NhanVien()
            {
                MaNhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text,
                DiaChi = txtDC.Text,
                SDT = txtsdt.Text,
                Email = txtEmail.Text,
                NgaySinh = dtpNgaySinh.Value.Date
            };

            List<string> errorMessages = new List<string>();

            if (!IsNVValid(nv))
            {

                errorMessages.Add("_ Định dạng email không hợp lệ (Định dạng email: example@gmail.com)\n" +
                    "_ Hoặc SĐT bắt đầu từ 0 và có 10 chữ số\n" +
                    "_ Hoặc ngày sinh không thể chọn ngày hiện tại");
            }

            if (!IsMaNVValidAndNotDuplicate(nv))
            {
                string newCode = GenerateUniqueMaNV(listNV.Select(n => n.MaNhanVien).ToList(), "NV");
                nv.MaNhanVien = newCode;
            }

            if (IsEmailDuplicate(nv))
            {
                errorMessages.Add("_ Email đã tồn tại.");
            }

            if (IsPhoneNumberDuplicate(nv))
            {
                errorMessages.Add("_ Số điện thoại đã tồn tại.");
            }

            if (errorMessages.Count > 0)
            {
                string errorMessage = string.Join("\n", errorMessages);
                MessageBox.Show("Thêm thất bại do:\n" + errorMessage);
            }
            else
            {
                bllNV.AddNV(nv);
                LoadListNV();
                Clear();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private bool isEditing; //biến kiểm tra trạng thái sửa đổi
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
                txtMaNhanVien.Enabled = false;

                if (isEditing)
                {
                    // Lấy dữ liệu từ các trường
                    string maNhanVien = txtMaNhanVien.Text;
                    string tenNhanVien = txtTenNhanVien.Text;
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string email = txtEmail.Text;
                    string sdt = txtsdt.Text;
                    string diaChi = txtDC.Text;

                    // Tạo đối tượng NhanVien từ dữ liệu vừa lấy
                    NhanVien nv = new NhanVien()
                    {
                        MaNhanVien = maNhanVien,
                        TenNhanVien = tenNhanVien,
                        NgaySinh = ngaySinh,
                        Email = email,
                        SDT = sdt,
                        DiaChi = diaChi
                    };

                    if (IsNVValid(nv))
                    {
                        bllNV.UpdateNV(nv); // Cập nhật dữ liệu vào CSDL
                        LoadListNV(); // Nạp lại danh sách nhân viên
                        Clear();

                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại thông tin.");
                    }

                    isEditing = false; // Chuyển trạng thái về là không sửa đổi
                    txtMaNhanVien.Enabled = true;
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            DataGridViewRow selectedRow = dgvNV.CurrentRow;
            string maNV = (selectedRow.Cells["MaNV"].Value ?? string.Empty).ToString();
            if (!string.IsNullOrEmpty(maNV))
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNV}?", "Xác nhận xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        bllNV.RemoveNV(maNV);
                        LoadListNV();
                        MessageBox.Show("Xóa nhân viên thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công. Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvNV.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvNV.Columns[i].HeaderText;
                }

                try
                {
                    for (int i = 0; i < dgvNV.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvNV.Columns.Count; j++)
                        {
                            DateTime NgaySinhValue = (DateTime)dgvNV.Rows[i].Cells[2].Value;
                            string NgaySinhFormated = NgaySinhValue.ToString("dd/MM/yyyy");

                            worksheet.Cells[i + 2, 3].Value = NgaySinhFormated;
                            worksheet.Cells[i + 2, j + 1].Value = dgvNV.Rows[i].Cells[j].Value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx|All Files|*.*",
                    FileName = "exportNV.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var file = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(file);
                    MessageBox.Show("Xuất dữ liệu thành công.");
                }
            }
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (var package = new ExcelPackage(new FileInfo(openFileDialog.FileName)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        int row = 2;
                        int maxMaNV = 0;

                        while (worksheet.Cells[row, 1].Value != null)
                        {
                            int maNhanVien;
                            if (int.TryParse(worksheet.Cells[row, 1].Value.ToString().Replace("NV", ""), out maNhanVien))
                            {
                                NhanVien nv = new NhanVien
                                {
                                    MaNhanVien = worksheet.Cells[row, 1].Value.ToString(),
                                    TenNhanVien = worksheet.Cells[row, 2].Value.ToString(),
                                    NgaySinh = DateTime.ParseExact(worksheet.Cells[row, 3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                    Email = worksheet.Cells[row, 4].Value.ToString(),
                                    SDT = worksheet.Cells[row, 5].Value.ToString(),
                                    DiaChi = worksheet.Cells[row, 6].Value.ToString()
                                };

                                if (IsMaNVValidAndNotDuplicate(nv))
                                {
                                    listNV.Add(nv);
                                    maxMaNV = Math.Max(maxMaNV, maNhanVien);
                                }
                            }
                            row++;
                        }

                        dgvNV.DataSource = null;
                        dgvNV.DataSource = listNV;
                        dgvNV.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
