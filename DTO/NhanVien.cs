using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string? MaNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Email { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }

        public NhanVien() { }
        public NhanVien(string? maNhanVien, string? tenNhanVien, DateTime? ngaySinh, string? email, string? sDT, string? diaChi)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            Email = email;
            SDT = sDT;
            DiaChi = diaChi;
        }
    }
}
