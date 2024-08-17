using DACK.BSA_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK.UseControls
{
    public partial class US_PHIEUMUONA : UserControl
    {
        public US_PHIEUMUONA()
        {
            InitializeComponent();
        }


        void resetTextBox()
        {
            this.txtMaPhieu.ResetText();
            this.txtMaSach.ResetText();
            this.txtMaThe.ResetText();
            this.dateNgayMuon.Value = DateTime.Now;
            this.dateNgayTra.Value = DateTime.Now;
            this.txtTim.ResetText();
        }

        void enableTextBox()
        {
            this.txtMaPhieu.Enabled = true;
            this.txtMaSach.Enabled = true;
            this.txtMaThe.Enabled = true;
            this.txtTim.Enabled = true;
            this.dateNgayMuon.Enabled = true;
            this.dateNgayTra.Enabled = true;
        }

        void disableTextBox()
        {
            this.txtMaPhieu.Enabled = false;
            this.txtMaSach.Enabled = false;
            this.txtMaThe.Enabled = false;
            this.dateNgayMuon.Enabled = false;
            this.dateNgayTra.Enabled = false;
        }


        DataTable dtphieuMuon = null;
        bool Them;
        string err;
        BLPhieuMuonA dbTP = new BLPhieuMuonA();
        void LoadData()
        {
            try
            {
                dtphieuMuon = new DataTable();
                dtphieuMuon.Clear();
                DataSet ds = dbTP.LayPhieuMuon();
                dtphieuMuon = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                grvPhieuMuon.DataSource = dtphieuMuon;
                // Thay đổi độ rộng cột
                grvPhieuMuon.AutoResizeColumns();
                resetTextBox();
                disableTextBox();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnHienThi.Enabled = true;

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                grvPhieuMuon_CellClick(null, null);


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }

        private void grvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = grvPhieuMuon.CurrentCell.RowIndex;

            this.txtMaPhieu.Text = grvPhieuMuon.Rows[r].Cells[0].Value.ToString();
            this.txtMaSach.Text = grvPhieuMuon.Rows[r].Cells[1].Value.ToString();
            this.txtMaThe.Text = grvPhieuMuon.Rows[r].Cells[2].Value.ToString();
            //this.dateNgayMuon.Text = grvPhieuMuon.Rows[r].Cells[2].Value.ToString();

            //this.dateNgayTra.Text = grvPhieuMuon.Rows[r].Cells[3].Value.ToString();

            object value1 = grvPhieuMuon.Rows[r].Cells[3].Value;
            object value2 = grvPhieuMuon.Rows[r].Cells[4].Value;

            if (value1 != null && value1 != DBNull.Value && DateTime.TryParse(value1.ToString(), out DateTime dateTimeValue1))
            {
                this.dateNgayMuon.Value = dateTimeValue1;
            }

            if (value2 != null && value2 != DBNull.Value && DateTime.TryParse(value2.ToString(), out DateTime dateTimeValue2))
            {
                this.dateNgayTra.Value = dateTimeValue2;
            }

        }

       
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grvPhieuMuon_CellClick(null, null);
            Them = false;

            enableTextBox();
         
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaSach.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime selectedNgayMuon = this.dateNgayMuon.Value;
            DateTime selectedNgayTra = this.dateNgayTra.Value;

            string MuonString = selectedNgayMuon.ToString("dd/MM/yyyy");
            string TraString = selectedNgayTra.ToString("dd/MM/yyyy");
            if (Them)
            {
                try
                {
                    BLPhieuMuonA blTp = new BLPhieuMuonA();
                    blTp.ThemPhieuMuon(this.txtMaPhieu.Text,this.txtMaSach.Text, this.txtMaThe.Text, MuonString, TraString, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLPhieuMuonA blTp = new BLPhieuMuonA();
                blTp.CapNhatPhieuMuon(this.txtMaPhieu.Text, this.txtMaSach.Text, this.txtMaThe.Text, MuonString, TraString, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Them = true;
            resetTextBox();
            enableTextBox();

            this.txtMaSach.Focus();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {

                int r = grvPhieuMuon.CurrentCell.RowIndex;
                string strDG1 = grvPhieuMuon.Rows[r].Cells[0].Value.ToString();
            
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    BLPhieuMuonA blTp = new BLPhieuMuonA();
                    string err = string.Empty;
                    blTp.XoaPhieuMuon(strDG1, ref err);
                    // Cập nhật lại DataGridView
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaSach.ResetText();
            this.txtMaThe.ResetText();
            this.dateNgayMuon.ResetText();
            this.dateNgayTra.ResetText();

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
          
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            grvPhieuMuon_CellClick(null, null);


        }

        private void US_PHIEUMUONA_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormReport report = new FormReport();
            report.ShowDialog();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

            string readerName = txtTim.Text;
            string error = string.Empty;
            BLPhieuMuonA blPhieuMuon = new BLPhieuMuonA();
            DataSet searchResult = null;
            if (txtTim.Text != "")
            {
                if (rdMaSach.Checked == true)
                {
                    searchResult = blPhieuMuon.TimKiemMS(readerName, ref error);
                }
                else if (rdmaThe.Checked == true)
                {
                    searchResult = blPhieuMuon.TimKiemMT(readerName, ref error);
                }

                if (searchResult != null)
                {
                    grvPhieuMuon.DataSource = searchResult.Tables[0];
                }
                else
                {
                    MessageBox.Show("Error occurred during search.");
                }
            }
            else LoadData();
        }
    }
}
