using DTO;
using RestSharp;
using System.Text.RegularExpressions;

namespace DAL
{
    public class QuanLy_DAL
    {
        private readonly List<NhanVien> listNV = new();

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
        

        //public List<Orders> GetListDataFrom()
        //{
        //    Uri Url = new Uri("http://data.gonsa.com.vn/api/order/getTrangThaiDonHang");
        //    var restClient = new RestClient(Url);
        //    RestRequest restRequest = new RestRequest("", Method.Get);
        //    var restResponse = restClient.Execute<List<Orders>>(restRequest);

        //    if (restResponse.IsSuccessful)
        //    {
        //        var data = restResponse.Data;
        //        //dgvTrangThaiDonHang.DataSource = data;
        //        return data;
        //    }
        //    else
        //    {
        //        Console.WriteLine(restResponse.ErrorMessage);
        //        return null;
        //    }
        //}

    }
}
