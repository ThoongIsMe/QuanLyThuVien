using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    internal class BlNXB
    {

        DBA_layer.DBAMain db;

        public BlNXB()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LayNXB()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tbNXB", CommandType.Text);
        }

        public bool ThemNXB(string MaNXB, string TenNXB, string DiaChi, string SDT, ref string err)
        {
            string sqlString = "INSERT INTO tbNXB (MaNXB, TenNXB, DiaChi, SDT) VALUES ('" +
                MaNXB + "', N'" +
                TenNXB + "', N'" +
                DiaChi + "', '" +
                SDT + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaNXB(string MaNXB, ref string err)
        {
            string sqlString = "DELETE FROM tbNXB WHERE MaNXB = '" + MaNXB + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatNXB(string MaNXB, string TenNXB, string DiaChi, string SDT, ref string err)
        {
            string sqlString = "UPDATE tbNXB SET TenNXB = N'" +
                TenNXB + "', DiaChi = N'" +
                DiaChi + "', SDT = '" +
                SDT + "' WHERE MaNXB = '" + MaNXB + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemTG(string readerName, ref string err)
        {
            string query = "SELECT * FROM tbNXB WHERE MaNXB LIKE '%" + readerName + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }
    }
}
