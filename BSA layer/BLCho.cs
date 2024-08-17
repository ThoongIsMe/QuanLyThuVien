using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DACK.BSA_layer
{
    internal class BLCho
    {
        DBA_layer.DBAMain db;
        public BLCho()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet Laysach()
        {
            return db.ExecuteQueryDataSet("select MaPhieu, tbChoDuyet.MaThe, MaDG,MaDauSach\r\nfrom tbthe,tbChoDuyet\r\nwhere tbthe.mathe = tbChoDuyet.MaThe", CommandType.Text);
        }

        public bool ThemPhieu(string MaPhieu,string MaThe, string MaDauSach, string TinhTrang, string Thongbao, ref string err)
        {
            string sqlString =
                  " INSERT INTO tbchoduyet(MaPhieu, MaThe, MaDauSach, TinhTrang, ThongBao)  " +
                   "VALUES ('" + MaPhieu + "','" + MaThe + "', '" + MaDauSach + "','" + TinhTrang + "','" + Thongbao + "'); ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ThemPhieuMuonDD(string MaPhieu, string MaDauSach, string MaThe, string NgayMuon, string NgayTra, ref string err)
        {
            string sqlString ="INSERT INTO tbPhieuMuon (MaPhieu, MaDauSach, MaThe, NgayMuon, NgayTra) " +
                "VALUES ('" + MaPhieu + "','" + MaDauSach + "', '" + MaThe + "', '" + NgayMuon + "', '" + NgayTra + "'); ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaPhieu(string MaDG, ref string err)
        {
            string sqlString = "DELETE FROM tbchoduyet WHERE MaPhieu = '" + MaDG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimKiemMP(string MaPhieu, ref string err)
        {

            string query = "select MaPhieu, tbChoDuyet.MaThe, MaDG,MaDauSach\r\nfrom tbthe,tbChoDuyet\r\nwhere tbthe.mathe = tbChoDuyet.MaThe and MaPhieu  LIKE '%" + MaPhieu + "%'";

            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }


        public DataSet TimKiemMDP(string MaThe, ref string err)
        {

            string query = "select MaPhieu, tbChoDuyet.MaThe, MaDG,MaDauSach\r\nfrom tbthe,tbChoDuyet\r\nwhere tbthe.mathe = tbChoDuyet.MaThe and MaDG  LIKE '%" + MaThe + "%'";

            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }

        public DataSet TimKiemMTUse(string MaThe, ref string err)
        {

            string query = "select MaPhieu, tbChoDuyet.MaThe, MaDG,MaDauSach\r\nfrom tbthe,tbChoDuyet\r\nwhere tbthe.mathe = tbChoDuyet.MaThe and MaDG = '" + MaThe + "'";

            return db.ExecuteQueryDataSet(query, CommandType.Text); // Execute the query with 'MaDG';
        }



        private int soluong;
        public int LaySoLuong(string MaDauSach, ref string err)
        {
            
            string query = $"SELECT soluong FROM tbdausach WHERE MaDauSach = '{MaDauSach}'";

            try
            {
                DataSet dataSet = db.ExecuteQueryDataSet(query, CommandType.Text);

                if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    soluong = Convert.ToInt32(dataSet.Tables[0].Rows[0]["soluong"]);
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return soluong;
        }


        public bool UpdateSoLuong(string MaDauSach, int SoLuong, ref string err)
        {
            string query = "UPDATE tbdausach SET [SoLuong] = @SoLuong WHERE [MaDauSach] = @MaDauSach";
            string ConnStr = "Data Source=HGTHONG\\MSSQLSERVER10;Initial Catalog=QLTV;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnStr))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SoLuong", SoLuong);
                        command.Parameters.AddWithValue("@MaDauSach", MaDauSach);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

    }
}
