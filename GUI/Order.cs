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

namespace WindowsFormsApp1
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
            txtMaTTDH.Enabled = false;
            txtTenTT.Enabled = false;
            txtMoTa.Enabled = false;
            AddDataSample();
            LoadData();
            addBinding();
        }

        List<Orders> dsTrangThai = new List<Orders>();
        BindingList<Orders> bindingList = new BindingList<Orders>();
        public int maTangDan = 5;
        public DataTable dt = new DataTable();

        private void AddDataSample()
        {
            dsTrangThai.Add(new Orders { MaTrangThaiDonHang = "Test 1", TenTrangThai = "Tên một", MoTa = "mô tả 1" });
            dsTrangThai.Add(new Orders { MaTrangThaiDonHang = "Test 2", TenTrangThai = "Tên hai", MoTa = "mô tả 2" });
            dsTrangThai.Add(new Orders { MaTrangThaiDonHang = "Test 3", TenTrangThai = "Tên ba", MoTa = "mô tả 3" });
            dsTrangThai.Add(new Orders { MaTrangThaiDonHang = "Test 4", TenTrangThai = "Tên bốn", MoTa = "mô tả 4" });

        }
        public List<Orders> getListOrderData()
        {
            return this.dsTrangThai;
        }
        private void addBinding()
        {
            if (dsTrangThai != null)
            {
                txtMaTTDH.DataBindings.Add(new Binding("Text", dgvDH.DataSource, "MaTrangThaiDonHang", true, DataSourceUpdateMode.Never));
                txtTenTT.DataBindings.Add(new Binding("Text", dgvDH.DataSource, "TenTrangThai", true, DataSourceUpdateMode.Never));
                txtMoTa.DataBindings.Add(new Binding("Text", dgvDH.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
            }
        }


        private void LoadData()
        {

            var bll = new QuanLy_BLL();
            dsTrangThai = bll.getListFromDAL();
            //DataTable table = ConvertListToDataTable(dsTrangThai);
            if (dsTrangThai != null)
            {
                dgvDH.DataSource = dsTrangThai;
            }
            dgvDH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadDataFromImport(List<Orders> list)
        {
            dgvDH.DataSource = null;
            dsTrangThai = list;
            //DataTable table = ConvertListToDataTable(dsTrangThai);

            dgvDH.DataSource = dsTrangThai;

            dgvDH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void resetDataGridView()
        {
            dgvDH.DataSource = null;
            dgvDH.DataSource = dsTrangThai;
            dgvDH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static DataTable ConvertListToDataTable<T>(List<T> list)

        {
            DataTable dataTable = new DataTable();

            // Get all the properties of the type T
            var properties = typeof(T).GetProperties();

            // Create DataTable columns based on the properties of the type T
            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }

            // Add data from the list to the DataTable
            foreach (var item in list)
            {
                var values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;

        }

        public void ToggleEdittable(bool type)
        {
            txtTenTT.Enabled = type;
            txtMoTa.Enabled = type;
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (btnEdit.Text.CompareTo("Bật Chỉnh Sửa") == 0)
        //    {
        //        ToggleEdittable(true);
        //        btnEdit.Text = "Tắt Chỉnh Sửa";
        //    }
        //    else
        //    {
        //        ToggleEdittable(false);
        //        btnEdit.Text = "Bật Chỉnh Sửa";
        //    }

        //}

        private void deleteAll()
        {
            txtMaTTDH.Text = string.Empty;
            txtTenTT.Text = string.Empty;
            txtMoTa.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (findData())
            {
                MessageBox.Show("Lưu Thành Công");
                deleteAll();
            }
            else
            {
                MessageBox.Show("Lưu Thất Bại");
            }
        }

        private bool findData()
        {
            if (string.IsNullOrEmpty(txtMaTTDH.Text) || string.IsNullOrEmpty(txtTenTT.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu cần nhập");
                return false;
            }
            else
            {
                string maTrangThai = txtMaTTDH.Text;
                string tenTrangThai = txtTenTT.Text;
                string mota = txtMoTa.Text;

                for (int i = 0; i < dsTrangThai.Count; i++)
                {
                    if (dsTrangThai[i].MaTrangThaiDonHang.CompareTo(maTrangThai) == 0)
                    {
                        dsTrangThai[i].TenTrangThai = tenTrangThai;
                        dsTrangThai[i].MoTa = mota;
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá dữ liệu này?", "Xác Nhận Xoá", MessageBoxButtons.YesNo);
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
            // kiểm tra hàng được chọn
            try
            {
                if (dsTrangThai.Count > 0)
                {
                    string maTrangThai = txtMaTTDH.Text;
                    for (int i = 0; i < dsTrangThai.Count; i++)
                    {
                        if (dsTrangThai[i].MaTrangThaiDonHang.CompareTo(maTrangThai) == 0)
                        {
                            dsTrangThai.RemoveAt(i);
                            break;
                        }
                    }

                    // Update  DataGridView
                    resetDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clipboard.SetText(ex.Message);
            }

        }
        private void btnNhapDH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm dữ liệu này?", "Xác Nhận Thêm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (addNewValue() == true)
                {
                    MessageBox.Show("Đã thêm thành công dữ liệu.");
                    resetDataGridView();
                    maTangDan++;
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private bool addNewValue()
        {
            if (string.IsNullOrEmpty(txtMaTTDH.Text) || string.IsNullOrEmpty(txtTenTT.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu cần nhập");
                return false;
            }
            else
            {
                Orders order = new Orders();
                order.MaTrangThaiDonHang = "OS" + maTangDan.ToString();
                order.TenTrangThai = txtTenTT.Text;
                order.MoTa = txtMoTa.Text;
                List<Orders> results = dsTrangThai.FindAll(x => x.MaTrangThaiDonHang == order.MaTrangThaiDonHang);
                if (results.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại mã " + order.MaTrangThaiDonHang);
                    return false;
                }
                else
                {
                    dsTrangThai.Add(order);
                    return true;
                }

            }

        }
        //private void txbSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //search_function();
        //    search_alter();

        //}

        //private void search_alter()
        //{
        //    dt = ConvertListToDataTable(dsTrangThai);
        //    DataView dv = dt.DefaultView;
        //    dv.RowFilter = "MaTrangThaiDonHang LIKE '" + txbSearch.Text + "%' OR TenTrangThai Like '" + txbSearch.Text + "%'";
        //    dgvDH.DataSource = dv;
        //}

        //private void search_function()
        //{
        //    if (txbSearch.Text != string.Empty)
        //        foreach (DataGridViewRow r in dgvDH.Rows)
        //        {
        //            if (r.Cells[1].EditedFormattedValue.ToString()!.Contains(txbSearch.Text) || r.Cells[2].EditedFormattedValue.ToString()!.Contains(txbSearch.Text))
        //                r.Visible = true;
        //            else
        //            {
        //                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvDH.DataSource];
        //                currencyManager1.SuspendBinding();
        //                dgvDH.Rows[r.Index].Visible = false;
        //                currencyManager1.ResumeBinding();
        //            }
        //        }
        //    else
        //        foreach (DataGridViewRow r in dgvDH.Rows)
        //            r.Visible = true;
        //    foreach (DataGridViewRow r in dgvDH.Rows)
        //    {
        //        if (r.Visible)
        //            dgvDH.FirstDisplayedScrollingRowIndex = r.Index;
        //        break;
        //    }
        //}

        private void dgvDH_Click(object sender, EventArgs e)
        {
            txtMaTTDH.DataBindings.Clear();
            txtTenTT.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();
            addBinding();
        }
    }
}
