using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK.BSA_layer
{
    internal class BLQLS
    {


        DBA_layer.DBAMain db;

        public BLQLS()
        {
            db = new DBA_layer.DBAMain();
        }

        public DataSet LaySach()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tbDauSach\r\n ", CommandType.Text);
        }

        public bool ThemSach(string MaDauSach, string TenSach, string MaNXB, string MaTG, string NamXuatBan, string ChuyenNganh, int SoLuong, string GhiChu, ref string err)
        {
            string sqlString = @"DECLARE @MaNXB VARCHAR(50) = '" + MaNXB + "';" +
                               @"DECLARE @MaTG VARCHAR(50) = '" + MaTG + "';" +
                               @"IF EXISTS (SELECT 1 FROM [dbo].[tbNXB] WHERE [MaNXB] = @MaNXB)" +
                               @"BEGIN " +
                               @"    IF EXISTS (SELECT 1 FROM [dbo].[tbTG] WHERE [MaTG] = @MaTG)" +
                               @"    BEGIN " +
                               @"        INSERT [dbo].[tbDauSach] ([MaDauSach], [TenSach], [MaNXB], [MaTG], [NamXuatBan], [ChuyenNganh], [SoLuong], [GhiChu]) " +
                               @"        VALUES ('" + MaDauSach + "', N'" + TenSach + "', '" + MaNXB + "', '" + MaTG + "', '" + NamXuatBan + "', N'" + ChuyenNganh + "', " + SoLuong + ", N'" + GhiChu + "')" +
                               @"    END " +
                               @"END " +
                               @"IF EXISTS (SELECT 1 FROM [dbo].[tbNXB] WHERE [MaNXB] = @MaNXB)" +
                               @"BEGIN " +
                               @"    IF NOT EXISTS (SELECT 1 FROM [dbo].[tbTG] WHERE [MaTG] = @MaTG)" +
                               @"    BEGIN " +
                               @"        INSERT INTO [dbo].[tbTG] ([MaTG], [TenTG], [DiaChi], [SDT], [Email]) " +
                               @"        VALUES (@MaTG, N'', N'', N'', N'')" +
                               @"        INSERT [dbo].[tbDauSach] ([MaDauSach], [TenSach], [MaNXB], [MaTG], [NamXuatBan], [ChuyenNganh], [SoLuong], [GhiChu]) " +
                               @"        VALUES ('" + MaDauSach + "', N'" + TenSach + "', '" + MaNXB + "', '" + MaTG + "', '" + NamXuatBan + "', N'" + ChuyenNganh + "', " + SoLuong + ", N'" + GhiChu + "')" +
                               @"    END " +
                               @"END " +
                               @"IF EXISTS (SELECT 1 FROM [dbo].[tbTG] WHERE [MaTG] = @MaTG)" +
                               @"BEGIN " +
                               @"    IF NOT EXISTS (SELECT 1 FROM [dbo].[tbNXB] WHERE [MaNXB] = @MaNXB)" +
                               @"    BEGIN " +
                               @"        INSERT INTO [dbo].[tbNXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) " +
                               @"        VALUES (@MaNXB, N'', N'', N'')" +
                               @"        INSERT [dbo].[tbDauSach] ([MaDauSach], [TenSach], [MaNXB], [MaTG], [NamXuatBan], [ChuyenNganh], [SoLuong], [GhiChu]) " +
                               @"        VALUES ('" + MaDauSach + "', N'" + TenSach + "', '" + MaNXB + "', '" + MaTG + "', '" + NamXuatBan + "', N'" + ChuyenNganh + "', " + SoLuong + ", N'" + GhiChu + "')" +
                               @"    END " +
                               @"END " +
                               @"IF NOT EXISTS (SELECT 1 FROM [dbo].[tbTG] WHERE [MaTG] = @MaTG)" +
                               @"BEGIN " +
                               @"    INSERT INTO [dbo].[tbTG] ([MaTG], [TenTG], [DiaChi], [SDT], [Email]) " +
                               @"    VALUES (@MaTG, N'', N'', N'', N'')" +
                               @"    IF NOT EXISTS (SELECT 1 FROM [dbo].[tbNXB] WHERE [MaNXB] = @MaNXB)" +
                               @"    BEGIN " +
                               @"        INSERT INTO [dbo].[tbNXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) " +
                               @"        VALUES (@MaNXB, N'', N'', N'')" +
                               @"        INSERT [dbo].[tbDauSach] ([MaDauSach], [TenSach], [MaNXB], [MaTG], [NamXuatBan], [ChuyenNganh], [SoLuong], [GhiChu]) " +
                               @"        VALUES ('" + MaDauSach + "', N'" + TenSach + "', '" + MaNXB + "', '" + MaTG + "', '" + NamXuatBan + "', N'" + ChuyenNganh + "', " + SoLuong + ", N'" + GhiChu + "')" +
                               @"    END " +
                               @"END";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public bool XoaSach(string MaDauSach, ref string err)
        {
            string sqlString = "DELETE FROM tbDauSach WHERE MaDauSach = '" + MaDauSach + "'; " +
                   "DELETE FROM tbTG WHERE MaTG = '" + MaDauSach + "'; ";


            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatSach(string MaDauSach, string TenSach, string MaNXB, string MaTG, string NamXuatBan, string ChuyenNganh, int SoLuong, string GhiChu, ref string err)
        {
            string sqlString = "DECLARE @MaNXB VARCHAR(50) = '" + MaNXB + "';" +
                       "DECLARE @MaTG VARCHAR(50) = '" + MaTG + "';" +
                       "DECLARE @MaDauSach VARCHAR(50) = '" + MaDauSach + "';" +
                       "IF NOT EXISTS (SELECT 1 FROM [dbo].[tbNXB] WHERE [MaNXB] = @MaNXB)" +
                       "BEGIN " +
                       "    INSERT [dbo].[tbNXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (@MaNXB, N'', N'', N'')" +
                       "END " +
                       "IF NOT EXISTS (SELECT 1 FROM [dbo].[tbTG] WHERE [MaTG] = @MaTG)" +
                       "BEGIN " +
                       "    INSERT [dbo].[tbTG] ([MaTG], [TenTG], [DiaChi], [SDT], [Email]) VALUES (@MaTG, N'', N'', N'', N'')" +
                       "END " +
                       "IF EXISTS (SELECT 1 FROM [dbo].[tbDauSach] WHERE [MaDauSach] = @MaDauSach)" +
                       "BEGIN " +
                       "    UPDATE [dbo].[tbDauSach] " +
                       "    SET [TenSach] = N'" + TenSach + "', [MaNXB] = @MaNXB, [MaTG] = @MaTG, [NamXuatBan] = '" + NamXuatBan + "', [ChuyenNganh] = N'" + ChuyenNganh + "', [SoLuong] = " + SoLuong + ", [GhiChu] = N'" + GhiChu + "' " +
                       "    WHERE [MaDauSach] = @MaDauSach " +
                       "END ";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemSach(string readerName, ref string err)
        {
            string query = "SELECT * FROM tbDauSach WHERE MaDauSach LIKE '%" + readerName + "%'";
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }

    }
}
