namespace UAS_PABD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiswa = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJurusan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKelas = new System.Windows.Forms.Button();
            this.btnOrtu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Mahasiswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSiswa
            // 
            this.btnSiswa.Location = new System.Drawing.Point(171, 165);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Size = new System.Drawing.Size(107, 33);
            this.btnSiswa.TabIndex = 1;
            this.btnSiswa.Text = "Pendaftaran";
            this.btnSiswa.UseVisualStyleBackColor = true;
            this.btnSiswa.Click += new System.EventHandler(this.btnSiswa_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(323, 165);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(144, 33);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form Admin";
            // 
            // btnJurusan
            // 
            this.btnJurusan.Location = new System.Drawing.Point(171, 218);
            this.btnJurusan.Name = "btnJurusan";
            this.btnJurusan.Size = new System.Drawing.Size(107, 30);
            this.btnJurusan.TabIndex = 4;
            this.btnJurusan.Text = "Jurusan";
            this.btnJurusan.UseVisualStyleBackColor = true;
            this.btnJurusan.Click += new System.EventHandler(this.btnJurusan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "PENERIMAAN MAHASISWA BARU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnKelas
            // 
            this.btnKelas.Location = new System.Drawing.Point(171, 269);
            this.btnKelas.Name = "btnKelas";
            this.btnKelas.Size = new System.Drawing.Size(107, 29);
            this.btnKelas.TabIndex = 6;
            this.btnKelas.Text = "Kelas";
            this.btnKelas.UseVisualStyleBackColor = true;
            this.btnKelas.Click += new System.EventHandler(this.btnKelas_Click);
            // 
            // btnOrtu
            // 
            this.btnOrtu.Location = new System.Drawing.Point(171, 318);
            this.btnOrtu.Name = "btnOrtu";
            this.btnOrtu.Size = new System.Drawing.Size(107, 31);
            this.btnOrtu.TabIndex = 7;
            this.btnOrtu.Text = "Orang Tua";
            this.btnOrtu.UseVisualStyleBackColor = true;
            this.btnOrtu.Click += new System.EventHandler(this.btnOrtu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UAS_PABD.Properties.Resources.UMY;
            this.pictureBox1.Location = new System.Drawing.Point(323, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(637, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrtu);
            this.Controls.Add(this.btnKelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJurusan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSiswa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiswa;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJurusan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKelas;
        private System.Windows.Forms.Button btnOrtu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}