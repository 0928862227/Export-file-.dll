using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien1
{
    internal class NhanVien
    {
        // Các thuộc tính private
        private string sID;
        private string hoTen;
        private int birthYear;
        private bool gender;
        private string phongBan;
        private string trinhDo;
        private string capBac;
        private int luongCoBan;
        private float heSo;

        // Constructor mặc định
        public NhanVien()
        {
            // Các thông số khác set mặc định
            SID = "";
            HoTen = "";
            BirthYear = 0;
            Gender = false;
            PhongBan = "";
            TrinhDo = "";
            CapBac = "";
            LuongCoBan = 0;
            HeSo = 0.0f;
        }

        // Constructor có truyền thông số
        public NhanVien(string sID, string hoTen, int birthYear, bool gender, string phongBan, string trinhDo, string capBac, int luongCoBan, float heSo)
        {
            // Kiểm tra năm sinh 
            if (birthYear > DateTime.Now.Year - 18)
            {
                throw new ArgumentException("năm sinh không hợp lệ");
            }
            //kiểm tra hệ số lương 
            if (heSo <= 0 || heSo >= 5)
            {
                throw new ArgumentException("Hệ số lương không hợp lệ");
            }

            // Gán giá trị
            this.SID = sID;
            this.HoTen = hoTen;
            this.BirthYear = birthYear;
            this.Gender = gender;
            this.PhongBan = phongBan;
            this.TrinhDo = trinhDo;
            this.CapBac = capBac;
            this.LuongCoBan = luongCoBan;
            this.HeSo = heSo;
        }

        // Các hàm get/set (bôi các hàm private + ctrl + r + e )
        public string SID { get => sID; set => sID = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string CapBac { get => capBac; set => capBac = value; }
        public int LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public float HeSo { get => heSo; set => heSo = value; }



        // Hàm Input
        public void Input()
        {
            Console.WriteLine("Nhập thông tin nhân viên:");
            Console.Write("Mã nhân viên: ");
            SID = Console.ReadLine();
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();
            bool isValidBirthYear = false;
            while (!isValidBirthYear)
            {
                Console.Write("Năm sinh: ");
                if (int.TryParse(Console.ReadLine(), out int inputBirthYear))
                {
                    if (DateTime.Now.Year - inputBirthYear > 18)
                    {
                        birthYear = inputBirthYear;
                        isValidBirthYear = true;
                    }
                    else
                    {
                        Console.WriteLine("Nhân viên phải lớn hơn 18 tuổi. Hãy nhập lại.");
                    }
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên cho năm sinh.");
                }
            }

        }

        // Hàm PrintInfor
        public void PrintInfor()
        {
            Console.WriteLine("Thông tin nhân viên:");
            Console.WriteLine($"Mã nhân viên: {SID}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Năm sinh: {BirthYear}");
        }

        // Hàm setTrinhDo
        public bool SetTrinhDo(string trinhDo)
        {
            // Kiểm tra điều kiện và thực hiện
            if (trinhDo == "Đại Học " || trinhDo == "Cao Đẳng" || trinhDo == "12/12")
            {
                this.TrinhDo = trinhDo;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Hàm setCapBac
        public bool SetCapBac(string capBac)
        {
            // Kiểm tra điều kiện và thực hiện
            if (capBac == "Intern" || capBac == "Senior" || capBac == "Leader")
            {
                this.CapBac = capBac;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Hàm tinhLuong
        public float TinhLuong()
        {
            return LuongCoBan * HeSo;
        }
    }
}
