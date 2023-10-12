using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Text.RegularExpressions;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class QLNV : UserControl
    {
        private readonly QuanLy_BLL bllNV;
        private List<NhanVien>? listNV;

        public QLNV()
        {
            InitializeComponent();
            bllNV = new QuanLy_BLL();
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.AutoGenerateColumns = false;
            AddDataSample();
            LoadListNV();
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1271, 855);
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
        private void LoadListNV()
        {
            listNV = bllNV.GetListNV();
            dgvNV.DataSource = null;
            dgvNV.DataSource = listNV;
        }
        private void Clear()
        {
            txtMaNV.Enabled = true;
            txtMaNV.Clear();
            txtTenNV.Clear();
            dtpNS.Value = DateTime.Now;
            txtEmail.Clear();
            txtSDT.Clear();
            txtDC.Clear();
        }
        private bool TextBoxesFilled()
        {
            return !string.IsNullOrWhiteSpace(txtMaNV.Text) &&
                   !string.IsNullOrWhiteSpace(txtTenNV.Text) &&
                   !string.IsNullOrWhiteSpace(txtDC.Text) &&
                   !string.IsNullOrWhiteSpace(txtSDT.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail.Text);
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
        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNV.CurrentRow;
            if (dr != null)
            {
                txtMaNV.Text = (dr.Cells["MaNV"].Value ?? string.Empty).ToString();
                txtTenNV.Text = (dr.Cells["TenNV"].Value ?? string.Empty).ToString();
                dtpNS.Value = Convert.ToDateTime(dr.Cells["NgaySinh"].Value ?? DateTime.Now);
                txtEmail.Text = (dr.Cells["Email"].Value ?? string.Empty).ToString();
                txtSDT.Text = (dr.Cells["SDT"].Value ?? string.Empty).ToString();
                txtDC.Text = (dr.Cells["DiaChi"].Value ?? string.Empty).ToString();
            }
            txtMaNV.Enabled = false;
        }
        private void QLNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TextBoxesFilled())
            {
                e.SuppressKeyPress = true;
                btnNhapNV_Click(sender, e);
            }
        }
        private void dgvNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvNV.Rows.Count; i++)
            {
                dgvNV.Rows[i].Cells["MaNV"].Value = "NV" + (i + 1);
            }
        }
        private void btnNhapNV_Click(object sender, EventArgs e)
        {
            dtpNS.Format = DateTimePickerFormat.Custom;
            dtpNS.CustomFormat = "dd/MM/yyyy";

            NhanVien nv = new NhanVien()
            {
                MaNhanVien = txtMaNV.Text,
                TenNhanVien = txtTenNV.Text,
                DiaChi = txtDC.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                NgaySinh = dtpNS.Value.Date
            };

            List<string> errorMessages = new List<string>();

            if (!IsNVValid(nv))
            {
                errorMessages.Add("_ Nhân viên không hợp lệ (Định dạng email: name@gmail.com, SĐT bắt đầu từ 0 và có 10 chữ số, ngày sinh không thể chọn ngày hiện tại).\n");
            }

            if (!IsMaNVValidAndNotDuplicate(nv))
            {
                errorMessages.Add("_ Mã nhân viên không hợp lệ hoặc trùng lặp.\n");
            }

            if (IsEmailDuplicate(nv))
            {
                errorMessages.Add("_ Email đã tồn tại.\n");
            }

            if (IsPhoneNumberDuplicate(nv))
            {
                errorMessages.Add("_ Số điện thoại đã tồn tại.");
            }

            if (errorMessages.Count > 0)
            {
                string errorMessage = string.Join("\n", errorMessages);
                MessageBox.Show("Thêm thất bại:\n" + errorMessage);
            }
            else
            {
                bllNV.AddNV(nv);
                LoadListNV();
                Clear();
                MessageBox.Show("Thêm thành công");
            }

        }
        private void btnXoaNV_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Xóa Nhân viên thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Nhân viên không thành công. Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private bool isEditing = false;

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
                txtMaNV.Enabled = false;

                DataGridViewRow selectedRow = dgvNV.CurrentRow;
                if (selectedRow != null)
                {
                    txtMaNV.Text = selectedRow.Cells["MaNV"].Value.ToString();
                    txtTenNV.Text = selectedRow.Cells["TenNV"].Value.ToString();
                    dtpNS.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                    txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                    txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                    txtDC.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                }
            }
            else
            {
                string maNhanVien = txtMaNV.Text;
                string tenNhanVien = txtTenNV.Text;
                DateTime ngaySinh = dtpNS.Value;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDC.Text;

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
                    bllNV.UpdateNV(nv);
                    LoadListNV();
                    Clear();
                    MessageBox.Show("Cập nhật thành công!");

                    isEditing = false;
                    txtMaNV.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại thông tin.");
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
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
        private void btnImport_Click(object sender, EventArgs e)
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
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
