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
using System.Configuration;
using System.Security.Cryptography;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class QLOrder : UserControl
    {
        public QLOrder()
        {
            InitializeComponent();
            bllTTDH = new QuanLy_BLL();
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
            List<Orders> dataList = (List<Orders>)dgvDH.DataSource;

            if (dataList != null)
            {
                for (int i = 0; i < dgvDH.Rows.Count; i++)
                {
                    dgvDH.Rows[i].Cells["maTrangThaiDonHang"].Value = dataList[i].MaTrangThaiDonHang;
                }
            }
        }
        private void QLOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtMaTTDH.Text) && !string.IsNullOrWhiteSpace(txtTenTT.Text) && !string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                e.SuppressKeyPress = true;
                btnNhapDH_Click(sender, e);
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
            txtMaTTDH.Enabled = true;
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
        private void SaveEncryptedDataToConfig(List<Orders> dataList)
        {
            string filePath = "MaHoa.config"; // Đường dẫn tới tệp MaHoa.config

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" ?><configuration><appSettings></appSettings></configuration>");

            XmlNode appSettingsNode = doc.SelectSingleNode("//appSettings");

            if (appSettingsNode != null)
            {
                foreach (var item in dataList)
                {
                    XmlElement addElement = doc.CreateElement("add");
                    addElement.SetAttribute("key", item.MaTrangThaiDonHang);
                    addElement.SetAttribute("value", item.TenTrangThai);
                    appSettingsNode.AppendChild(addElement);
                }

                doc.Save(filePath);
            }
        }
        private List<Orders> GetEncryptedDataFromConfig()
        {
            List<Orders> encryptedDataList = new List<Orders>();

            string filePath = "MaHoa.config"; // Đường dẫn tới tệp MaHoa.config

            // Kiểm tra xem tệp tồn tại
            if (File.Exists(filePath))
            {
                // Nạp tệp cấu hình XML
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                // Lấy danh sách các phần tử <add>
                XmlNodeList addNodes = doc.SelectNodes("//appSettings/add");

                foreach (XmlNode addNode in addNodes)
                {
                    string key = addNode.Attributes["key"].Value;
                    string value = addNode.Attributes["value"].Value;

                    encryptedDataList.Add(new Orders
                    {
                        MaTrangThaiDonHang = key,
                        TenTrangThai = value
                    });
                }
            }

            return encryptedDataList;
        }
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            try
            {
                List<Orders> dataList = (List<Orders>)dgvDH.DataSource;


                if (dataList != null)
                {
                    foreach (var item in dataList)
                    {
                        item.MaTrangThaiDonHang = Encrypt(item.MaTrangThaiDonHang);
                        item.TenTrangThai = Encrypt(item.TenTrangThai);
                    }

                    dgvDH.DataSource = null;
                    dgvDH.DataSource = dataList;

                    SaveEncryptedDataToConfig(dataList);

                    MessageBox.Show("Mã hóa dữ liệu thành công và lưu vào MaHoa.config!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mã hóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            try
            {
                List<Orders> encryptedDataList = GetEncryptedDataFromConfig();

                if (encryptedDataList != null)
                {
                    foreach (var item in encryptedDataList)
                    {
                        item.MaTrangThaiDonHang = Decrypt(item.MaTrangThaiDonHang);
                        item.TenTrangThai = Decrypt(item.TenTrangThai);
                    }

                    dgvDH.DataSource = null;
                    dgvDH.DataSource = encryptedDataList;

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files|*.txt";
                    saveFileDialog.FileName = "DecryptedData.txt";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        SaveDecryptedDataToTextFile(encryptedDataList, filePath);

                        MessageBox.Show("Giải mã dữ liệu thành công và lưu vào tệp văn bản!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi giải mã dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu dữ liệu đã giải mã vào tệp văn bản
        private void SaveDecryptedDataToTextFile(List<Orders> dataList, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in dataList)
                {
                    writer.WriteLine($"MaTrangThaiDonHang: {item.MaTrangThaiDonHang}, TenTrangThai: {item.TenTrangThai}");
                }
            }
        }

        // Hàm mã hóa văn bản sử dụng AES
        private string Encrypt(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("1234567890123456"); // Thay thế bằng khóa mã hóa của bạn
                aesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456"); // Thay thế bằng vector khởi tạo của bạn

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(input);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Hàm giải mã văn bản sử dụng AES
        private string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("1234567890123456");
                aesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456");

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}

