namespace UAS_PABD
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnis = new System.Windows.Forms.TextBox();
            this.txtnamasiswa = new System.Windows.Forms.TextBox();
            this.txttgllhr = new System.Windows.Forms.TextBox();
            this.txtjk = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtagama = new System.Windows.Forms.TextBox();
            this.txtkj = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.siswabaruBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pendaftaran_siswa2DataSet1 = new UAS_PABD.pendaftaran_siswa2DataSet1();
            this.siswabaruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pendaftaran_siswa2DataSet = new UAS_PABD.pendaftaran_siswa2DataSet();
            this.btnback = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.siswa_baruTableAdapter = new UAS_PABD.pendaftaran_siswa2DataSetTableAdapters.siswa_baruTableAdapter();
            this.siswa_baruTableAdapter1 = new UAS_PABD.pendaftaran_siswa2DataSet1TableAdapters.siswa_baruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswabaruBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_siswa2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswabaruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_siswa2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Pendaftaran Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Siswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Agama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kode Jurusan";
            // 
            // txtnis
            // 
            this.txtnis.Location = new System.Drawing.Point(178, 87);
            this.txtnis.Name = "txtnis";
            this.txtnis.Size = new System.Drawing.Size(117, 20);
            this.txtnis.TabIndex = 8;
            // 
            // txtnamasiswa
            // 
            this.txtnamasiswa.Location = new System.Drawing.Point(178, 119);
            this.txtnamasiswa.Name = "txtnamasiswa";
            this.txtnamasiswa.Size = new System.Drawing.Size(117, 20);
            this.txtnamasiswa.TabIndex = 9;
            // 
            // txttgllhr
            // 
            this.txttgllhr.Location = new System.Drawing.Point(178, 150);
            this.txttgllhr.Name = "txttgllhr";
            this.txttgllhr.Size = new System.Drawing.Size(117, 20);
            this.txttgllhr.TabIndex = 10;
            // 
            // txtjk
            // 
            this.txtjk.Location = new System.Drawing.Point(178, 179);
            this.txtjk.Name = "txtjk";
            this.txtjk.Size = new System.Drawing.Size(117, 20);
            this.txtjk.TabIndex = 11;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(178, 212);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(117, 20);
            this.txtalamat.TabIndex = 12;
            // 
            // txtagama
            // 
            this.txtagama.Location = new System.Drawing.Point(178, 244);
            this.txtagama.Name = "txtagama";
            this.txtagama.Size = new System.Drawing.Size(117, 20);
            this.txtagama.TabIndex = 13;
            // 
            // txtkj
            // 
            this.txtkj.Location = new System.Drawing.Point(178, 278);
            this.txtkj.Name = "txtkj";
            this.txtkj.Size = new System.Drawing.Size(117, 20);
            this.txtkj.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(337, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(410, 150);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // siswabaruBindingSource1
            // 
            this.siswabaruBindingSource1.DataMember = "siswa_baru";
            this.siswabaruBindingSource1.DataSource = this.pendaftaran_siswa2DataSet1;
            // 
            // pendaftaran_siswa2DataSet1
            // 
            this.pendaftaran_siswa2DataSet1.DataSetName = "pendaftaran_siswa2DataSet1";
            this.pendaftaran_siswa2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswabaruBindingSource
            // 
            this.siswabaruBindingSource.DataMember = "siswa_baru";
            this.siswabaruBindingSource.DataSource = this.pendaftaran_siswa2DataSet;
            // 
            // pendaftaran_siswa2DataSet
            // 
            this.pendaftaran_siswa2DataSet.DataSetName = "pendaftaran_siswa2DataSet";
            this.pendaftaran_siswa2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 406);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Kembali";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(206, 334);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(646, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(494, 271);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // siswa_baruTableAdapter
            // 
            this.siswa_baruTableAdapter.ClearBeforeFill = true;
            // 
            // siswa_baruTableAdapter1
            // 
            this.siswa_baruTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtkj);
            this.Controls.Add(this.txtagama);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtjk);
            this.Controls.Add(this.txttgllhr);
            this.Controls.Add(this.txtnamasiswa);
            this.Controls.Add(this.txtnis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswabaruBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_siswa2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswabaruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_siswa2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnis;
        private System.Windows.Forms.TextBox txtnamasiswa;
        private System.Windows.Forms.TextBox txttgllhr;
        private System.Windows.Forms.TextBox txtjk;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtagama;
        private System.Windows.Forms.TextBox txtkj;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private pendaftaran_siswa2DataSet pendaftaran_siswa2DataSet;
        private System.Windows.Forms.BindingSource siswabaruBindingSource;
        private pendaftaran_siswa2DataSetTableAdapters.siswa_baruTableAdapter siswa_baruTableAdapter;
        private pendaftaran_siswa2DataSet1 pendaftaran_siswa2DataSet1;
        private System.Windows.Forms.BindingSource siswabaruBindingSource1;
        private pendaftaran_siswa2DataSet1TableAdapters.siswa_baruTableAdapter siswa_baruTableAdapter1;
    }
}