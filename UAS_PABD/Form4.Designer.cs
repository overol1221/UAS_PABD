namespace UAS_PABD
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtkkodejrsn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnamajrsn = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDftr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Daftar Jurusan Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Jurusan";
            // 
            // txtkkodejrsn
            // 
            this.txtkkodejrsn.Location = new System.Drawing.Point(175, 135);
            this.txtkkodejrsn.Name = "txtkkodejrsn";
            this.txtkkodejrsn.Size = new System.Drawing.Size(195, 20);
            this.txtkkodejrsn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Jurusan";
            // 
            // txtnamajrsn
            // 
            this.txtnamajrsn.Location = new System.Drawing.Point(175, 169);
            this.txtnamajrsn.Name = "txtnamajrsn";
            this.txtnamajrsn.Size = new System.Drawing.Size(195, 20);
            this.txtnamajrsn.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(175, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDftr
            // 
            this.btnDftr.Location = new System.Drawing.Point(256, 218);
            this.btnDftr.Name = "btnDftr";
            this.btnDftr.Size = new System.Drawing.Size(75, 23);
            this.btnDftr.TabIndex = 6;
            this.btnDftr.Text = "Daftar";
            this.btnDftr.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDftr);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtnamajrsn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkkodejrsn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkkodejrsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnamajrsn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDftr;
    }
}