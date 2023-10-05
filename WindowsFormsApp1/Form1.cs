using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OfficeOpenXml;
using System.IO;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1022, 650);
        }

        List<NhanVien> listNV = new List<NhanVien>();
        private bool IsMaNVDuplicate(string MaNV)
        {
            foreach (NhanVien nv in listNV)
            {
                if (nv.MaNhanVien == MaNV)
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsEmailDuplicate(string email)
        {
            foreach (NhanVien nv in listNV)
            {
                if (nv.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsSDTDuplicate(string sdt)
        {
            foreach (NhanVien nv in listNV)
            {
                if (nv.SDT == sdt)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsValidMaNV(string MaNV)
        {
            Regex regex = new Regex(@"^NV\d+$");
            return regex.IsMatch(MaNV);
        }
        private bool IsValidPhoneNumber(string SDT)
        {
            if (SDT.Length == 10 && SDT[0] == '0')
            {
                foreach (char c in SDT)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        private bool IsValidEmail(string Email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch
            {
                return false;
            }
        }
        private void Clear()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDC.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dtpNS.Value = DateTime.Now;
        }
        private bool TextBoxesFilled()
        {
            return !string.IsNullOrWhiteSpace(txtMaNV.Text) &&
                   !string.IsNullOrWhiteSpace(txtTenNV.Text) &&
                   !string.IsNullOrWhiteSpace(txtDC.Text) &&
                   !string.IsNullOrWhiteSpace(txtSDT.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail.Text);
        }
        private void btnNhapNV_Click_1(object sender, EventArgs e)
        {
            dtpNS.Format = DateTimePickerFormat.Custom;
            dtpNS.CustomFormat = "dd/MM/yyyy";

            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNV.Text;
            nv.TenNhanVien = txtTenNV.Text;
            nv.DiaChi = txtDC.Text;
            nv.SDT = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.NgaySinh = dtpNS.Value.Date;

            if (!IsValidMaNV(nv.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng nhập đúng định dạng (vd: NV1, NV2,...)");
                return;
            }
            else if (!IsMaNVDuplicate(nv.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập lại.");
                return;
            }

            if (!IsValidEmail(nv.Email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng (vd: example@example.com).");
                return;
            }
            else if (IsEmailDuplicate(nv.Email))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng nhập lại.");
                return;
            }

            if (!IsValidPhoneNumber(nv.SDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại bắt đầu từ 0 và có 10 chữ số.");
                return;
            }
            else if (IsSDTDuplicate(nv.SDT))
            {
                MessageBox.Show("SĐT đã tồn tại. Vui lòng nhập lại.");
                return;
            }

            listNV.Add(nv);

            qlnv1.DgvNVText.DataSource = null;
            qlnv1.DgvNVText.DataSource = listNV;

            Clear();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TextBoxesFilled())
            {
                e.SuppressKeyPress = true;
                btnNhapNV_Click_1(sender, e);
            }
        }
        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {
            if (qlnv1.DgvNVText.SelectedRows.Count > 0)
            {

                DataGridViewRow Row = qlnv1.DgvNVText.SelectedRows[0];

                NhanVien nv = (NhanVien)Row.DataBoundItem;

                listNV.Remove(nv);

                qlnv1.DgvNVText.DataSource = null;
                qlnv1.DgvNVText.DataSource = listNV;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }
        private void btnSuaNV_Click_1(object sender, EventArgs e)
        {
            var nv = listNV.FirstOrDefault(a => a.MaNhanVien == txtMaNV.Text);
            if (nv != null)
            {
                if (!string.IsNullOrWhiteSpace(txtTenNV.Text))
                    nv.TenNhanVien = txtTenNV.Text;

                if (!string.IsNullOrWhiteSpace(txtSDT.Text) && IsValidPhoneNumber(txtSDT.Text))
                    nv.SDT = txtSDT.Text;

                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && IsValidEmail(txtEmail.Text))
                    nv.Email = txtEmail.Text;

                if (!string.IsNullOrWhiteSpace(txtDC.Text))
                    nv.DiaChi = txtDC.Text;

                nv.NgaySinh = dtpNS.Value;

                int selectedIndex = 0;
                qlnv1.DgvNVText.Rows[selectedIndex].Cells[1].Value = nv.TenNhanVien;
                qlnv1.DgvNVText.Rows[selectedIndex].Cells[2].Value = nv.NgaySinh;
                qlnv1.DgvNVText.Rows[selectedIndex].Cells[3].Value = nv.SDT;
                qlnv1.DgvNVText.Rows[selectedIndex].Cells[4].Value = nv.Email;
                qlnv1.DgvNVText.Rows[selectedIndex].Cells[5].Value = nv.DiaChi;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < qlnv1.DgvNVText.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = qlnv1.DgvNVText.Columns[i].HeaderText;
                }

                try
                {
                    for (int i = 0; i < qlnv1.DgvNVText.Rows.Count; i++)
                    {
                        for (int j = 0; j < qlnv1.DgvNVText.Columns.Count; j++)
                        {
                            DateTime NgaySinhValue = (DateTime)qlnv1.DgvNVText.Rows[i].Cells[2].Value;
                            string NgaySinhFormated = NgaySinhValue.ToString("dd/MM/yyyy");

                            worksheet.Cells[i + 2, 3].Value = NgaySinhFormated;
                            worksheet.Cells[i + 2, j + 1].Value = qlnv1.DgvNVText.Rows[i].Cells[j].Value;
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
                }
            }
        }
        private void ImportExcel(string path)
        {
            using (ExcelPackage excel = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = excel.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();

                for (int i = worksheet.Dimension.Start.Column; i <= worksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(worksheet.Cells[1, i].Value.ToString());
                }

                for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                {
                    List<string> list = new List<string>();
                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                    {
                        list.Add(worksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(list.ToArray());
                }

                qlnv1.DgvNVText.DataSource = dataTable;
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

                        NhanVien nhanVien = new NhanVien();
                        int maxMaNV = 0;

                        for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                        {
                            int maNhanVien;
                            if (int.TryParse(worksheet.Cells[row, 1].Value.ToString().Replace("NV", ""), out maNhanVien))
                            {
                                if (!IsMaNVDuplicate("NV" + maNhanVien))
                                {
                                    maxMaNV = Math.Max(maxMaNV, maNhanVien);
                                }
                                else
                                {
                                    maxMaNV++;
                                }

                                NhanVien nv = new NhanVien
                                {
                                    MaNhanVien = worksheet.Cells[row, 1].Value.ToString(),
                                    TenNhanVien = worksheet.Cells[row, 2].Value.ToString(),
                                    NgaySinh = DateTime.ParseExact(worksheet.Cells[row, 3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                    Email = worksheet.Cells[row, 4].Value.ToString(),
                                    SDT = worksheet.Cells[row, 5].Value.ToString(),
                                    DiaChi = worksheet.Cells[row, 6].Value.ToString()
                                };
                                
                                listNV.Add(nv);
                                qlnv1.RefreshData();
                            }
                            
                        }

                        qlnv1.DgvNVText.DataSource = listNV;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
