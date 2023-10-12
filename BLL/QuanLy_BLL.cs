using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLy_BLL
    {
        private readonly QuanLy_DAL nhanVien;
        private readonly QuanLy_DAL order;

        public QuanLy_BLL()
        {
            nhanVien = new QuanLy_DAL();
            order = new QuanLy_DAL();
        }
        public List<NhanVien> GetListNV()
        {
            return nhanVien.GetListNV();
        }
        public void AddNV(NhanVien nv)
        {

            nhanVien.AddNV(nv);
        }
        public void RemoveNV(string MaNV)
        {
            nhanVien.RemoveNV(MaNV);
        }
        public void UpdateNV(NhanVien nv)
        {
            nhanVien.UpdateNV(nv);
        }
        public List<Orders> getListDHFromDAL()
        {
            var api = new QuanLy_DAL();
            return api.GetListDHFromAPI();
        }
        public void UpdateDH(Orders or)
        {
            order.UpdateDH(or);
        }
    }
}
