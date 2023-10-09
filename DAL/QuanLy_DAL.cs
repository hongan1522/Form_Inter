using DTO;
using RestSharp;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace DAL
{
    public class QuanLy_DAL
    {
        private readonly List<NhanVien> listNV = new();
        private readonly List<Orders> listTTDH = new();

        public List<NhanVien> GetListNV()
        {
            return listNV;
        }
        public void AddNV(NhanVien nv)
        {
            listNV.Add(nv);
        }
        public void RemoveNV(string MaNV)
        {
            var nvToRemove = listNV.FirstOrDefault(nv => nv.MaNhanVien == MaNV);

            if (nvToRemove != null)
            {
                listNV.Remove(nvToRemove);
            }
        }
        public void UpdateNV(NhanVien nv)
        {
            var existingNV = listNV.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);

            if (existingNV != null)
            {
                existingNV.TenNhanVien = nv.TenNhanVien;
                existingNV.NgaySinh = nv.NgaySinh;
                existingNV.Email = nv.Email;
                existingNV.SDT = nv.SDT;
                existingNV.DiaChi = nv.DiaChi;
            }
        }

        public List<Orders> GetListDHFromAPI()
        {
            Uri Url = new Uri("http://data.gonsa.com.vn/api/order/getTrangThaiDonHang");
            var restClient = new RestClient(Url);
            RestRequest restRequest = new RestRequest("", Method.Get);
            var restResponse = restClient.Execute<List<Orders>>(restRequest);

            if (restResponse.IsSuccessful)
            {
                var data = restResponse.Data;
                return data;
            }
            else
            {
                Console.WriteLine(restResponse.ErrorMessage);
                return null;
            }
        }
        public List<Orders> GetListDH()
        {
            return listTTDH;
        }
        public void AddDH(Orders or)
        {
            listTTDH.Add(or);
        }
        public void RemoveDH(string MaDH)
        {
            var dhToRemove = listTTDH.FirstOrDefault(or => or.MaTrangThaiDonHang == or.MaTrangThaiDonHang);

            if (dhToRemove != null)
            {
                listTTDH.Remove(dhToRemove);
            }
        }
        public void UpdateDH(Orders or)
        {
            var existingDH = listTTDH.FirstOrDefault(o => o.MaTrangThaiDonHang == or.MaTrangThaiDonHang);

            if (existingDH != null)
            {
                existingDH.TenTrangThai = or.TenTrangThai;
                existingDH.MoTa = or.MoTa;
            }
        }

        //public void AddOrderFromApi()
        //{
        //    List<Orders> orders = GetListDHFromAPI();

        //    if (orders != null)
        //    {
        //        foreach (Orders order in orders)
        //        {
        //            AddOrder(order);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Không thể lấy dữ liệu từ API.");
        //    }
        //}
        //public void AddOrder(Orders order)
        //{
        //    // Kết nối đến cơ sở dữ liệu
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Tạo câu truy vấn SQL để thêm đơn hàng
        //        string query = "INSERT INTO Orders (MaTrangThaiDonHang, TenTrangThai, MoTa) VALUES (@OrderStatusID, @StatusName, @Describe)";

        //        // Tạo đối tượng SqlCommand
        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            // Thay thế các tham số trong câu truy vấn với giá trị tương ứng từ đối tượng Orders
        //            cmd.Parameters.AddWithValue("@OrderStatusID", order.MaTrangThaiDonHang);
        //            cmd.Parameters.AddWithValue("@StatusName", order.TenTrangThai);
        //            cmd.Parameters.AddWithValue("@Describe", order.MoTa);

        //            // Thực thi câu truy vấn
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

    }
}
