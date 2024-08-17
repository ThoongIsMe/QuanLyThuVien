using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    internal class BLThongKeA
    {

        DBA_layer.DBAMain db;

        public BLThongKeA()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LayDocGia()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tbDG", CommandType.Text);
        }
        public int DemSoLuongSach()
        {
            string sqlQuery = "SELECT sum(soluong) FROM tbdausach\r\n";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }


        public int DemSoLuongSachChuaTra()
        {
            string sqlQuery = "SELECT COUNT(*) AS SoLuong\r\nFROM tbphieumuon\r\nWHERE CONVERT(date, NgayTra, 103) > CONVERT(date, GETDATE(), 103);";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }

        public int DemSoLuongSachDaTra()
        {
            string sqlQuery = "SELECT COUNT(*) AS SoLuong\r\nFROM tbphieumuon\r\nWHERE CONVERT(date, NgayTra, 103) < CONVERT(date, GETDATE(), 103);";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }


        public int DemSoDocGia()
        {
            string sqlQuery = "SELECT count(MaDG) FROM tbDG";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }

        public int DemSoNXB()
        {
            string sqlQuery = "SELECT count(*) FROM tbnxb";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }
        public int DemPhieuMuon()
        {
            string sqlQuery = "SELECT count(*) FROM tbphieumuon";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }
        public int DemSoTacGia()
        {
            string sqlQuery = "SELECT count(*) FROM tbTG";
            string error = string.Empty;
            int count = 0;
            DataSet result = db.ExecuteQueryDataSet(sqlQuery, CommandType.Text);
            if (result.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            }
            return count;
        }

        public DataSet LayPhieuQuaHan()
        {
            return db.ExecuteQueryDataSet("SELECT MaDG,tbthe.MaThe, MaDauSach, \r\nCONVERT(date, NgayMuon, 103)as NgayMuon,\r\nCONVERT(date, NgayTra, 103) AS NgayTra \r\nFROM tbphieumuon\r\nLEFT JOIN tbthe ON tbphieumuon.mathe = tbthe.mathe\r\nWHERE CONVERT(date, NgayTra, 103) > CONVERT(date, GETDATE())", CommandType.Text);
        }

        public DataSet LayPhieuDaTra()
        {
            return db.ExecuteQueryDataSet("SELECT MaDG,tbthe.MaThe, MaDauSach, \r\nCONVERT(date, NgayMuon, 103)as NgayMuon,\r\nCONVERT(date, NgayTra, 103) AS NgayTra \r\nFROM tbphieumuon\r\nLEFT JOIN tbthe ON tbphieumuon.mathe = tbthe.mathe\r\nWHERE CONVERT(date, NgayTra, 103) < CONVERT(date, GETDATE())", CommandType.Text);
        }


    }
}
