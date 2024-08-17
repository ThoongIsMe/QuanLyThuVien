using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    public class BLTacGiaA
    {
        DBA_layer.DBAMain db;

        public BLTacGiaA()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LayTacGia()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tbTG", CommandType.Text);
        }

        public bool ThemTacGia(string MaTG, string TenTG, string DiaChi, string SDT, string Email, ref string err)
        {
            string sqlString = "INSERT INTO tbTG (MaTG, TenTG, DiaChi, SDT, Email) VALUES ('" +
                MaTG + "', N'" +
                TenTG + "', N'" +
                DiaChi + "', '" +
                SDT + "', '" +
                Email + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaTacGia(string MaTG, ref string err)
        {
            string sqlString = "DELETE FROM tbTG WHERE MaTG = '" + MaTG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatTacGia(string MaTG, string TenTG, string DiaChi, string SDT, string Email, ref string err)
        {
            string sqlString = "UPDATE tbTG SET TenTG = N'" +
                TenTG + "', DiaChi = N'" +
                DiaChi + "', SDT = '" +
                SDT + "', Email = '" +
                Email + "' WHERE MaTG = '" + MaTG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemTG(string readerName, ref string err)
        {
            string query = "SELECT * FROM tbTG WHERE MaTG LIKE '%" + readerName + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }

    }

}
