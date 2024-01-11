using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien1
{
    internal class QuanLyNhanVien
    {
        // Các thuộc tính private
        public int maNV { get; set; }
        public string tenNV { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public DateTime ngayvaolam { get; set; }
        public string bangcap { get; set; }
        public string hinhthucNV { get; set; }


        // Constructor mặc định
        public QuanLyNhanVien()
        {
          
        }

        // Constructor có truyền thông số
        public QuanLyNhanVien(string sID, string hoTen, int birthYear, bool gender, string phongBan, string trinhDo, string capBac, int luongCoBan, float heSo, global::System.Int32 maNV, global::System.String tenNV, DateTime ngaysinh, global::System.String gioitinh, global::System.String diachi, DateTime ngayvaolam, global::System.String bangcap, global::System.String hinhthucNV)
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

            tthis.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.ngayvaolam = ngayvaolam;
            this.bangcap = bangcap;
            this.hinhthucNV = hinhthucNV;

        }
        public double timeworking(int start, int end)
        {
            // Thời gian làm vc = end - start.
            // thgian < 8h 
            // 1. nếu trễ <1.5 tiếng ngày làm vc được tính 1 ngày 
            // 2. nếu trễ 1.5-2h ngày làm vc được tính 1/2 ngày
            // thgian làm vc từ 8-12 tiếng: mỗi giờ thêm được tính bằng 2 giờ làm bình thường

            


        }

        public double Tinhphep(string dieuKien, int ngayNghi)
        {
            // Nếu thâm niên >= 12 thì 
            // 1. Điều kiện bình thương có ngayphep là 12
            // 2. điều kiện đặc biệt có ngayphep là 14
            //3. điều kiện nặng nhọc có ngày phép là 16
            // Ngược lại thâm niên <12 thì ngayphep = thamNien
            // nếu nghỉ quá ngày phép thì tiền phạt = bằng 20% lương tháng
            // nếu ngày nghỉ <0 (tức là đi làm thêm ca) thì những ngày làm thêm lương = 200% lương thông thường
        }

        public double TinhPhuCap()
        {
            //Hocvi // = THPT Phụ cấp 0;  // trung cấp phụ cấp 2000, // cao đẳng phụ cấp 4000, đại học phụ cấp 6000 // thạc sỉ phụ cấp 8000 // tiến sĩ phụ cấp 10000
            // Chức danh: "Nhan vien": phụ cấp chức danh = 2000; "Pho truong phong":phụ cấp chức danh  = 5000;  "Truong phong": phụ cấp = 10000;
            // phụ cấp phòng ban: Kinh doanh phụ cấp 5000; "Ke toan phụ cấp  5000; Ban giam docphụ cấp  = 20000; "Hanh chanh"phụ cấp 10000;  "Bao ve" phụ cấp1000;
            // luongThang = LCB + luongThamNien + luongHocVi + luongChucDanh + luongPhongBan;           
        }


        public double TinhluongParttime(string loaiCV)
        {
            //loaiCV là "Van phong": lương partime 19000;
            //loaiCV  "San xuat":luongParttime = 20000;
        }

        public double Tinhluong()
        {
            // Số giờ làm được tính = giờ làm - ngày nghỉ phép 
            //    luong = luongGio * gioLam + Phucap - thue;
        }

        public double TinhThue()
        {
            //BHXH = luongThang * 8 / 100;
            //BHYT = luongThang * 1.5 / 100;
            //BHTN = luongThang * 1 / 100;
            //TNCN = luongThang * 10 / 100;
            //thue = BHXH + BHYT + BHTN + TNCN;

        }

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
