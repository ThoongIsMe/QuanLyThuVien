using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    internal class BLMK
    {
        DBA_layer.DBAMain db;

        public BLMK()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LayMadg()
        {
            return db.ExecuteQueryDataSet("select * from tbMK", CommandType.Text);
        }

        public bool CapNhatMatKhau(string MaDG, string MatKhau, ref string err)
        {
            string sqlString = "UPDATE tbMK SET MatKhau = '" + MatKhau + "' WHERE MaDG = '" + MaDG + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemMaDG(string readerName, ref string err)
        {
            string query = "SELECT * FROM tbMK WHERE MaDG LIKE '%" + readerName + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }
    }
}
