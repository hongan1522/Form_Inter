using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public NhanVien(string maNV, string tenNV, DateTime ngaysinh, string email, string sdt, string diachi)
        {
            MaNhanVien = maNV;
            TenNhanVien = tenNV;
            NgaySinh = ngaysinh;
            Email = email;
            SDT = sdt;
            DiaChi = diachi;
        }
    }

}
