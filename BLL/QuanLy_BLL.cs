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
            //if(!IsMaNVValidAndNotDuplicate(nv.MaNhanVien)) 
            //{
            //    Console.WriteLine("Mã nhân viên không hợp lệ (định dạng: NV1, NV2,...) hoặc đã tồn tại. Vui lòng nhập lại.");
            //    return;
            //}

            //if(!IsPhoneNumberValidAndNotDuplicate(nv.SDT))
            //{
            //    Console.WriteLine("SĐT không hợp lệ (phải bắt đầu từ 0 và có 10 số) hoặc đã tồn tại. Vui lòng nhập lại.");
            //    return;
            //}
            
            //if(!IsEmailValidAndNotDuplicate(nv.Email))
            //{
            //    Console.WriteLine("Email không hợp lệ (định dạng: example@example.com) hoặc đã tồn tại. Vui lòng nhập lại.");
            //    return;
            //}

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
        //public bool IsMaNVValidAndNotDuplicate(string MaNV)
        //{
        //    return nhanVien.IsMaNVValidAndNotDuplicate(MaNV);
        //}
        //public bool IsPhoneNumberValidAndNotDuplicate(string sdt)
        //{
        //    return nhanVien.IsPhoneNumberValidAndNotDuplicate(sdt);
        //}
        //public bool IsEmailValidAndNotDuplicate(string email) 
        //{
        //    return nhanVien.IsEmailValidAndNotDuplicate(email);
        //}

        //public List<Orders> getListFromDAL()
        //{
        //    var api = new QuanLy_DAL();
        //    return api.GetListDataFrom();
        //}
    }
}
