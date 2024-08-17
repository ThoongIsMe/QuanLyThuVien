using DACK.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }


        public bool checkAdmin = true;
      
        public static string MaDG { get; private set; } = "";
        public static string MKcu { get; private set; } = "";



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (checkAdmin)
            {
                if (this.txtUserName.Text == "1" && this.txtPassword.Text == "1")
                {
                    this.Hide();
                    MenuAdmin formDangNhap = new MenuAdmin();
                    formDangNhap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nhập sai thông tin, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUserName.Focus();
                }
            }

            else
            {
                SqlConnection sqlcon = new SqlConnection("Data Source=HGTHONG\\MSSQLSERVER10;Initial Catalog=QLTV;Integrated Security=True");
                string query = "Select * from tbMK Where MaDG = '" + txtUserName.Text.Trim() + "' and MatKhau = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    FDangNhap.MaDG = txtUserName.Text.Trim();
                    FDangNhap.MKcu = txtPassword.Text.Trim();
                    this.Hide();
                    Menu formDangNhap = new Menu();
                    formDangNhap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }

                
            }
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            checkAdmin = true;
        }

        private void rdDG_CheckedChanged(object sender, EventArgs e)
        {
            checkAdmin = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Hide();
                FDangNhap formDangNhap = Application.OpenForms["dangnhap"] as FDangNhap;
                if (formDangNhap != null)
                {
                    formDangNhap.ShowDialog();
                }
            }
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
              
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbHienMK.Checked==true)
            {
                this.txtPassword.UseSystemPasswordChar = false;  
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
            
        }
    }
}
