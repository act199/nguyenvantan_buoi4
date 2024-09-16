using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyenvantan_buoi4
{
    internal class SinhVien
    {
        string MSSV;
        
        string hoTen;
        
        string gioiTinh;
        
        DateTime ngaySinh;
        
        string diaChi;
       
        // viết hàm khởi tạo
        // Hàm khởi tạo không có tham số
        public SinhVien() { }
        public SinhVien(string MSSV, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi) 
        { 
            this.MSSV1 = MSSV;
            this.HoTen = hoTen;
            this.GioiTinh=gioiTinh;
            this.NgaySinh=ngaySinh;
            this.DiaChi=diaChi;
        }

        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
