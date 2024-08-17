using DACK.DBA_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    internal class BLThe
    {
        DBA_layer.DBAMain db;

        public BLThe()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LayThe()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tbthe", CommandType.Text);
        }
       

        public bool XoaThe(string MaThe, ref string err)
        {
            string sqlString = "DELETE FROM tbThe WHERE MaThe = '" + MaThe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatThe(string MaThe, string MaDG, string NgayCap, string Han, ref string err)
        {
            string sqlString = "UPDATE tbThe SET MaThe = '" +
                MaThe + "', NgayCap = '" +
                NgayCap + "', Han = '" +
                Han + "' WHERE  MaDG = '" + MaDG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimKiemMaThe(string MaThe, ref string err)
        {
            string query = "SELECT * FROM tbThe WHERE MaThe LIKE '%" + MaThe + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        public DataSet TimKiemMaDG(string MaDG, ref string err)
        {
            string query = "SELECT * FROM tbThe WHERE MaDG LIKE '%" + MaDG + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        public bool CheckHanThe(string MaDG,ref string err)
        {
            string strSQL = "SELECT TOP 1 Han FROM tbThe WHERE MaDG ='" + MaDG + "'";
            CommandType commandType = CommandType.Text;

            DBAMain dbaMain = new DBAMain();
            DataSet ds = dbaMain.ExecuteQueryDataSet(strSQL, commandType);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                string hanValue = ds.Tables[0].Rows[0]["Han"].ToString();
                if (!string.IsNullOrEmpty(hanValue))
                {
                    DateTime han;
                    if (DateTime.TryParse(hanValue, out han))
                    {
                        if (han < DateTime.Now)
                            return false;
                    }
                }
            }
            return true;
        }

    }
}
