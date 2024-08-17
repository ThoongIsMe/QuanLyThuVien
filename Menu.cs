using DACK.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK
{
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
            Menu_Load();
        }
        private void addUS(UserControl useControls)
        {
            useControls.Dock = DockStyle.Fill;
            pnMenu.Controls.Clear();
            pnMenu.Controls.Add(useControls);
            pnMenu.BringToFront();

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            US_TTCN uc = new US_TTCN();
            addUS(uc);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            US_Sach uc = new US_Sach();
            addUS(uc);
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            US_PhieuMuon uc = new US_PhieuMuon();
            addUS(uc);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            US_Home uc = new US_Home();
            addUS(uc);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FDangNhap me_ad = new FDangNhap();
                me_ad.ShowDialog();
                this.Close();
            }
        }

        public void Menu_Load()
        {
            US_TTCN usTTCN = new US_TTCN();
            this.lbMaDG.Text = FDangNhap.MaDG;
            usTTCN.TimDocGia();
            this.lbTen.Text = US_TTCN.TennDG;
        }


    }
}
