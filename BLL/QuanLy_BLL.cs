using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLy_BLL
    {
        private readonly QuanLy_DAL nhanVien;

        public QuanLy_BLL()
        {
            nhanVien = new QuanLy_DAL();
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

        public List<Orders> getListFromDAL()
        {
            var api = new QuanLy_DAL();
            return api.GetListDataFrom();
        }
    }
}
