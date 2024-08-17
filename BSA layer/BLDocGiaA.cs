using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DACK.BSA_layer
{
    internal class BLDocGiaA
    {
        DBA_layer.DBAMain db;

        public BLDocGiaA()
        {
            db = new DBA_layer.DBAMain();
        }
        private string GenerateRandomMaThe()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 1000001); 

            string maThe = randomNumber.ToString("D6"); 

            return maThe;
        }

        public DataSet LayDocGia()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tbDG", CommandType.Text);
        }

        public bool ThemDocGia(string MaDG, string TenDG, string ChucVu, string Lop, string Khoa, string NgaySinh, string GioiTinh, string GhiChu, ref string err)
        {

            string maThe = GenerateRandomMaThe(); // Hàm tạo mã thẻ ngẫu nhiên

            DateTime ngayCap = DateTime.Now; // Ngày cấp là ngày hiện tại
            DateTime ngayHetHan = ngayCap.AddYears(4); // Ngày hết hạn là ngày cấp + 4 năm

            // Định dạng ngày theo chuỗi "dd/MM/yyyy"
            string ngayCapFormatted = ngayCap.ToString("dd/MM/yyyy");
            string ngayHetHanFormatted = ngayHetHan.ToString("dd/MM/yyyy");

            string sqlString = "INSERT INTO tbDG (MaDG, TenDG, ChucVu, Lop, Khoa, NgaySinh, GioiTinh, GhiChu) VALUES ('" +
                MaDG + "', N'" +
                TenDG + "', N'" +
                ChucVu + "', '" +
                Lop + "', N'" +
                Khoa + "', '" +
                NgaySinh + "', N'" +
                GioiTinh + "', N'" +
                GhiChu + "')" + $"INSERT INTO tbMK (MaDG, MatKhau) VALUES ('{MaDG}', '1')" +
                $"INSERT INTO tbthe (MaThe, MaDG, NgayCap, Han) VALUES ('{maThe}', '{MaDG}', '{ngayCapFormatted}', '{ngayHetHanFormatted}')"; 

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaDocGia(string MaDG, ref string err)
        {
           
            string sqlString = "DELETE FROM tbDG WHERE MaDG = '" + MaDG + "'" + 
                "DELETE FROM tbMK WHERE MaDG = '" + MaDG + "'" +
               "DELETE FROM tbthe WHERE MaDG = '" + MaDG + "'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatDocGia(string MaDG, string TenDG, string ChucVu, string Lop, string Khoa, string NgaySinh, string GioiTinh, string GhiChu, ref string err)
        {


            string sqlString = "UPDATE tbDG SET TenDG = N'" +
                TenDG + "', ChucVu = N'" +
                ChucVu + "', Lop = '" +
                Lop + "', Khoa = N'" +
                Khoa + "', NgaySinh = '" +
                NgaySinh + "', GioiTinh = N'" +
                GioiTinh + "', GhiChu = N'" +
                GhiChu + "' WHERE MaDG = '" + MaDG + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemDG(string MaDG, ref string err)
        {
            string query = "SELECT * FROM tbDG WHERE MaDG LIKE '%" + MaDG + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }

        public DataSet TimKiemDG1(string MaDG, ref string err)
        {
            string query = "\tselect tbdg.MaDG, TenDG, ChucVu,Lop,Khoa,NgaySinh,GioiTinh,GhiChu,mathe from tbthe,tbdg\r\n\twhere tbdg.madg = tbthe.madg and tbthe.madg LIKE '%" + MaDG + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }

        public DataSet TimKiemTenDG(string readerName, ref string err)
        {
            string query = "SELECT * FROM tbDG WHERE TenDG LIKE '%" + readerName + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }


    }
}
