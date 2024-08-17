using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    internal class BLPhieuMuonA
    {
        DBA_layer.DBAMain db;
        public BLPhieuMuonA()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LayPhieuMuon()
        {
            return db.ExecuteQueryDataSet("SELECT * from tbPhieuMuon ", CommandType.Text);
        }

      

        public bool ThemPhieuMuon(string MaPhieu ,string MaDauSach, string MaThe, string NgayMuon, string NgayTra, ref string err)
        {
            string sqlString =
                   "INSERT INTO tbPhieuMuon (MaPhieu, MaDauSach, MaThe, NgayMuon, NgayTra) " +
                   "VALUES ('" + MaPhieu + "','" + MaDauSach + "', '" + MaThe + "', '" + NgayMuon + "', '" + NgayTra + "'); ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaPhieuMuon(string MaPhieu, ref string err)
        {
            string sqlString = "DELETE FROM tbPhieuMuon WHERE MaPhieu = '" + MaPhieu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatPhieuMuon(string MaPhieu, string MaDauSach, string MaThe, string NgayMuon, string NgayTra, ref string err)
        {
            string sqlString =
                "UPDATE tbPhieuMuon " +
                "SET MaDauSach = '" + MaDauSach + "', " +
                "MaThe = '" + MaThe + "', " +
                "NgayMuon = '" + NgayMuon + "', " +
                "NgayTra = '" + NgayTra + "' " +
                "WHERE MaPhieu = '" + MaPhieu + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimKiemMS(string MaDauSach, ref string err)
        {
            string query = "SELECT * FROM tbPhieuMuon WHERE MaDauSach  LIKE '%" + MaDauSach + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }

        public DataSet TimKiemMT(string MaThe, ref string err)
        {
            string query = "SELECT * FROM tbPhieuMuon WHERE MaThe  LIKE '%" + MaThe + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }

        public DataSet TimKiemMTUse(string MaThe, ref string err)
        {   
            string query = "select MaPhieu,MaDG,tbthe.MaThe, MaDauSach,NgayMuon,NgayTra from tbthe,tbphieumuon\r\nwhere tbthe.mathe = tbphieumuon.mathe and MaDG = '" + MaThe + "'";
            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }

       
    }
}
