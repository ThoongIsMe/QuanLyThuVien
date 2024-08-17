﻿using DACK.BSA_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK.UseControls
{
    public partial class US_PhieuMuon : UserControl
    {
        string curentDG;
        

        DataTable dtDGA = null;
        bool Them;
        string err;
        BLPhieuMuonA dbGDA = new BLPhieuMuonA();

        public US_PhieuMuon()
        {
            InitializeComponent();
            this.txtPM.Enabled = false;
            this.txtMaGD.Enabled = false;
            this.txtThe.Enabled = false;
            this.dateTra.Enabled = false;
            this.dateMuon.Enabled = false;
            curentDG = FDangNhap.MaDG;
            this.txtMaGD.Text = FDangNhap.MaDG;
            TimPhieuMuon();
        }


        public void TimPhieuMuon()
        {
            BSA_layer.BLPhieuMuonA blDG = new BSA_layer.BLPhieuMuonA();
            string err = string.Empty;

            dtDGA = new DataTable();
            dtDGA.Clear();
            DataSet ds1 = dbGDA.TimKiemMTUse(curentDG, ref err);
            dtDGA = ds1.Tables[0];
            // Đưa dữ liệu lên DataGridView
            grvPhieuMuon.DataSource = dtDGA;
            // Thay đổi độ rộng cột
            grvPhieuMuon.AutoResizeColumns();

            DataSet ds = blDG.TimKiemMTUse(curentDG, ref err);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    this.txtPM.Text = row["MaPhieu"].ToString();
                    this.txtMaGD.Text = row["MaDG"].ToString();
                    
                    this.txtThe.Text = row["MaThe"].ToString();


                    DateTime dateTime = DateTime.ParseExact(row["NgayMuon"].ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    this.dateMuon.Value = dateTime;

                    DateTime dateTime1 = DateTime.ParseExact(row["NgayTra"].ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    this.dateTra.Value = dateTime1;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin độc giả.");
            }


        }


        private void grvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grvPhieuMuon.Rows.Count) // Kiểm tra chỉ số hàng hợp lệ
            {
                DataGridViewRow row = grvPhieuMuon.Rows[e.RowIndex];

                this.txtPM.Text = row.Cells["MaPhieu"].Value.ToString();
                this.txtMaGD.Text = row.Cells["MaDG"].Value.ToString();
                this.txtThe.Text = row.Cells["MaThe"].Value.ToString();
                this.txtThe.Enabled = false;
                DateTime dateTimeMuon = DateTime.ParseExact(row.Cells["NgayMuon"].Value.ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                this.dateMuon.Value = dateTimeMuon;
                DateTime dateTimeTra = DateTime.ParseExact(row.Cells["NgayTra"].Value.ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                this.dateTra.Value = dateTimeTra;
            }
        }

        private void US_PhieuMuon_Load(object sender, EventArgs e)
        {
            
        }
    }
}
