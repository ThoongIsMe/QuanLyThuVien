namespace DACK.UseControls
{
    partial class US_FMuoncs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDSM = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDSM
            // 
            this.btnDSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnDSM.FlatAppearance.BorderSize = 0;
            this.btnDSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSM.Font = new System.Drawing.Font("Bree Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSM.ForeColor = System.Drawing.Color.White;
            this.btnDSM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSM.Location = new System.Drawing.Point(115, 271);
            this.btnDSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSM.Name = "btnDSM";
            this.btnDSM.Size = new System.Drawing.Size(240, 66);
            this.btnDSM.TabIndex = 22;
            this.btnDSM.Text = "DS Dã Duyệt";
            this.btnDSM.UseVisualStyleBackColor = false;
            this.btnDSM.Click += new System.EventHandler(this.btnDSM_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DACK.Properties.Resources.nxb;
            this.pictureBox2.Location = new System.Drawing.Point(567, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DACK.Properties.Resources.sách2;
            this.pictureBox1.Location = new System.Drawing.Point(115, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnCho
            // 
            this.btnCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCho.FlatAppearance.BorderSize = 0;
            this.btnCho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCho.Font = new System.Drawing.Font("Bree Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCho.ForeColor = System.Drawing.Color.White;
            this.btnCho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCho.Location = new System.Drawing.Point(567, 271);
            this.btnCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCho.Name = "btnCho";
            this.btnCho.Size = new System.Drawing.Size(240, 66);
            this.btnCho.TabIndex = 23;
            this.btnCho.Text = "DS Chờ Duyệt";
            this.btnCho.UseVisualStyleBackColor = false;
            this.btnCho.Click += new System.EventHandler(this.btnCho_Click);
            // 
            // US_FMuoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCho);
            this.Controls.Add(this.btnDSM);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "US_FMuoncs";
            this.Size = new System.Drawing.Size(988, 640);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDSM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCho;
    }
}
