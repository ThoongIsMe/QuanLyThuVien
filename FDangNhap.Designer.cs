﻿namespace DACK
{
    partial class FDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdDG = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bree Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(79, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Usename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(679, 222);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(233, 34);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(681, 292);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 34);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Checked = true;
            this.rdAdmin.Font = new System.Drawing.Font("Bree Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAdmin.Location = new System.Drawing.Point(681, 391);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(83, 28);
            this.rdAdmin.TabIndex = 6;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "&Admin";
            this.rdAdmin.UseVisualStyleBackColor = true;
            this.rdAdmin.CheckedChanged += new System.EventHandler(this.rdAdmin_CheckedChanged);
            // 
            // rdDG
            // 
            this.rdDG.AutoSize = true;
            this.rdDG.Font = new System.Drawing.Font("Bree Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDG.Location = new System.Drawing.Point(820, 391);
            this.rdDG.Name = "rdDG";
            this.rdDG.Size = new System.Drawing.Size(92, 28);
            this.rdDG.TabIndex = 7;
            this.rdDG.TabStop = true;
            this.rdDG.Text = "&Độc Giả";
            this.rdDG.UseVisualStyleBackColor = true;
            this.rdDG.CheckedChanged += new System.EventHandler(this.rdDG_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Bree Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(568, 440);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(141, 45);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "&Đăng Nhâp";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Bree Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(787, 440);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Font = new System.Drawing.Font("Bree Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHienMK.Location = new System.Drawing.Point(679, 346);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(143, 28);
            this.cbHienMK.TabIndex = 10;
            this.cbHienMK.Text = "Hiện Mật Khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(680, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = " Sign In";
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(968, 510);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.rdDG);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FDangNhap";
            this.Text = "FDangNhap";
            this.Load += new System.EventHandler(this.FDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdDG;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.Label label3;
    }
}