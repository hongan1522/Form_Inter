using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Drawing.Drawing2D;
using System.Net;
using OfficeOpenXml;
using System.IO;
using System.IO.Packaging;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class QLOrder : UserControl
    {
        public QLOrder()
        {
            InitializeComponent();
            bllTTDH = new QuanLy_BLL();
            //txtMaTTDH.Enabled = false;
            dgvDH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDH.AutoGenerateColumns = false;
            AddDataSample();
            LoadData();
        }

        List<Orders> listTTDH = new List<Orders>();
        private readonly QuanLy_BLL bllTTDH;

        private void LoadListTTDH()
        {
            listTTDH = bllTTDH.getListDHFromDAL();
            // Xóa các dòng hiện tại trên DataGridView
            dgvDH.Rows.Clear();

            foreach (var item in listTTDH)
            {
                dgvDH.Rows.Add(item.MaTrangThaiDonHang, item.TenTrangThai, item.MoTa);
            }
        }

        private void dgvDH_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDH.CurrentRow;
            if (dr != null)
            {
                txtMaTTDH.Text = (dr.Cells["maTrangThaiDonHang"].Value ?? string.Empty).ToString();
                txtTenTT.Text = (dr.Cells["tenTrangThai"].Value ?? string.Empty).ToString();
                txtMoTa.Text = (dr.Cells["moTa"].Value ?? string.Empty).ToString();
            }
            txtMaTTDH.Enabled = false;
        }
        private void dgvDH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvDH.Rows.Count; i++)
            {
                dgvDH.Rows[i].Cells["maTrangThaiDonHang"].Value = "OS00" + (i + 1);
            }
        }
        private void AddDataSample()
        {
            List<Orders> listTTDHMau = new List<Orders>();
            {
                listTTDHMau.Add(new Orders { MaTrangThaiDonHang = "OS008", TenTrangThai = "Tên A", MoTa = "Mô tả 1" });
                listTTDHMau.Add(new Orders { MaTrangThaiDonHang = "OS009", TenTrangThai = "Tên B", MoTa = "Mô tả 2" });
                listTTDHMau.Add(new Orders { MaTrangThaiDonHang = "OS010", TenTrangThai = "Tên C", MoTa = "Mô tả 3" });
                listTTDHMau.Add(new Orders { MaTrangThaiDonHang = "OS011", TenTrangThai = "Tên D", MoTa = "Mô tả 4" });
            }
            //dgvDH.DataSource = listTTDHMau;
            LoadListTTDH();
        }
        private void LoadData()
        {

            var bll = new QuanLy_BLL();
            listTTDH = bll.getListDHFromDAL();
            //DataTable table = ConvertListToDataTable(listTTDH);
            if (listTTDH != null)
            {
                dgvDH.DataSource = listTTDH;
            }
            dgvDH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadDataFromImport(List<Orders> list)
        {
            dgvDH.DataSource = null;
            listTTDH = list;
            //DataTable table = ConvertListToDataTable(listTTDH);

            dgvDH.DataSource = listTTDH;

            dgvDH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void resetDataGridView()
        {
            dgvDH.DataSource = null;
            dgvDH.DataSource = listTTDH;
            dgvDH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private bool AddNewDH()
        {
            if (string.IsNullOrEmpty(txtMaTTDH.Text) || string.IsNullOrEmpty(txtTenTT.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu cần nhập");
                return false;
            }
            else
            {
                Orders order = new Orders();
                //order.MaTrangThaiDonHang = "OS00" + maTangDan.ToString();
                order.TenTrangThai = txtTenTT.Text;
                order.MoTa = txtMoTa.Text;
                List<Orders> results = listTTDH.FindAll(x => x.MaTrangThaiDonHang == order.MaTrangThaiDonHang);
                if (results.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại mã " + order.MaTrangThaiDonHang);
                    return false;
                }
                else
                {
                    listTTDH.Add(order);
                    return true;
                }
            }
        }
        private void btnNhapDH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc thêm đơn hàng này?", "Xác nhận thêm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (AddNewDH() == true)
                {
                    MessageBox.Show("Thêm thành công đơn hàng.");
                    resetDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng thất bại!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void CleartxtDH()
        {
            txtMaTTDH.Clear();
            txtTenTT.Clear();
            txtMoTa.Clear();
        }
        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá đơn hàng này?", "Xác Nhận Xoá", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deleteARow();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }
        private void deleteARow()
        {
            try
            {
                if (listTTDH.Count > 0)
                {
                    string maTrangThai = txtMaTTDH.Text;
                    for (int i = 0; i < listTTDH.Count; i++)
                    {
                        if (listTTDH[i].MaTrangThaiDonHang.CompareTo(maTrangThai) == 0)
                        {
                            listTTDH.RemoveAt(i);
                            break;
                        }
                    }

                    resetDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clipboard.SetText(ex.Message);
            }

        }
        private void btnSuaDH_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvDH.CurrentRow;

            if (selectedRow != null)
            {
                txtMaTTDH.Enabled = false;
                string tenTT = txtTenTT.Text;
                string moTa = txtMoTa.Text;

                Orders or = new Orders()
                {
                    TenTrangThai = tenTT,
                    MoTa = moTa
                };

                bllTTDH.UpdateDH(or);

                selectedRow.Cells["tenTrangThai"].Value = tenTT;
                selectedRow.Cells["moTa"].Value = moTa;

                CleartxtDH();

                MessageBox.Show("Đã sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
        private void btnRefreshDH_Click(object sender, EventArgs e)
        {
            CleartxtDH();
        }
        private void btnExportDH_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.DefaultExt = "xlsx";
                sfd.FileName = "export_TTDH";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(sfd.FileName);
                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Orders");

                        for (int i = 1; i <= dgvDH.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dgvDH.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < dgvDH.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvDH.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dgvDH[j, i].Value;
                            }
                        }

                        package.Save();
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }
        public bool IsMaNVValidAndNotDuplicate(Orders order)
        {
            // Kiểm tra Mã trạng thái đơn hàng không được null hoặc rỗng
            if (string.IsNullOrEmpty(order.MaTrangThaiDonHang))
            {
                MessageBox.Show("Mã trạng thái đơn hàng không được rỗng.");
                return false;
            }

            // Kiểm tra xem maTrangThaiDonHang có đúng định dạng không
            Regex regex = new(@"^OS\d+$");
            if (!regex.IsMatch(order.MaTrangThaiDonHang))
            {
                MessageBox.Show("Mã trạng thái đơn hàng không hợp lệ. Vui lòng nhập đúng định dạng (vd: OS001, OS002,....)");
                return false;
            }

            // Kiểm tra xem maTrangThaiDonHang đã tồn tại trong danh sách đơn hàng chưa
            foreach (Orders or in listTTDH)
            {
                if (or.MaTrangThaiDonHang == order.MaTrangThaiDonHang)
                {
                    return false;
                }
            }

            return true;
        }
        private void btnImportDH_Click(object sender, EventArgs e)
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
                        int maxMaTTDH = 0;

                        while (worksheet.Cells[row, 1].Value != null)
                        {
                            int maTTDH;
                            if (int.TryParse(worksheet.Cells[row, 1].Value.ToString().Replace("OS", ""), out maTTDH))
                            {
                                Orders or = new Orders()
                                {
                                    MaTrangThaiDonHang = worksheet.Cells[row, 1].Value.ToString(),
                                    TenTrangThai = worksheet.Cells[row, 2].Value.ToString(),
                                    MoTa = worksheet.Cells[row, 3].Value.ToString()
                                };

                                if (IsMaNVValidAndNotDuplicate(or))
                                {
                                    listTTDH.Add(or);
                                    maxMaTTDH = Math.Max(maxMaTTDH, maTTDH);
                                }
                            }
                            row++;
                        }

                        dgvDH.DataSource = null;
                        dgvDH.DataSource = listTTDH;
                        dgvDH.Refresh();
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

