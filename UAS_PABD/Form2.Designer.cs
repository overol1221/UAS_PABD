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
            this.nisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggallahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodejurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswabaruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pendaftaran_siswa2DataSet = new UAS_PABD.pendaftaran_siswa2DataSet();
            this.btnback = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.siswa_baruTableAdapter = new UAS_PABD.pendaftaran_siswa2DataSetTableAdapters.siswa_baruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswabaruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_siswa2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Data Siswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Siswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Agama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 428);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kode Jurusan";
            // 
            // txtnis
            // 
            this.txtnis.Location = new System.Drawing.Point(267, 134);
            this.txtnis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnis.Name = "txtnis";
            this.txtnis.Size = new System.Drawing.Size(174, 26);
            this.txtnis.TabIndex = 8;
            // 
            // txtnamasiswa
            // 
            this.txtnamasiswa.Location = new System.Drawing.Point(267, 182);
            this.txtnamasiswa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamasiswa.Name = "txtnamasiswa";
            this.txtnamasiswa.Size = new System.Drawing.Size(174, 26);
            this.txtnamasiswa.TabIndex = 9;
            // 
            // txttgllhr
            // 
            this.txttgllhr.Location = new System.Drawing.Point(267, 231);
            this.txttgllhr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttgllhr.Name = "txttgllhr";
            this.txttgllhr.Size = new System.Drawing.Size(174, 26);
            this.txttgllhr.TabIndex = 10;
            // 
            // txtjk
            // 
            this.txtjk.Location = new System.Drawing.Point(267, 275);
            this.txtjk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtjk.Name = "txtjk";
            this.txtjk.Size = new System.Drawing.Size(174, 26);
            this.txtjk.TabIndex = 11;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(267, 326);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(174, 26);
            this.txtalamat.TabIndex = 12;
            // 
            // txtagama
            // 
            this.txtagama.Location = new System.Drawing.Point(267, 375);
            this.txtagama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtagama.Name = "txtagama";
            this.txtagama.Size = new System.Drawing.Size(174, 26);
            this.txtagama.TabIndex = 13;
            // 
            // txtkj
            // 
            this.txtkj.Location = new System.Drawing.Point(267, 428);
            this.txtkj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkj.Name = "txtkj";
            this.txtkj.Size = new System.Drawing.Size(174, 26);
            this.txtkj.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nisDataGridViewTextBoxColumn,
            this.namasiswaDataGridViewTextBoxColumn,
            this.tanggallahirDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.agamaDataGridViewTextBoxColumn,
            this.kodejurusanDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.siswabaruBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(505, 126);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(615, 231);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // nisDataGridViewTextBoxColumn
            // 
            this.nisDataGridViewTextBoxColumn.DataPropertyName = "nis";
            this.nisDataGridViewTextBoxColumn.HeaderText = "nis";
            this.nisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nisDataGridViewTextBoxColumn.Name = "nisDataGridViewTextBoxColumn";
            this.nisDataGridViewTextBoxColumn.Width = 125;
            // 
            // namasiswaDataGridViewTextBoxColumn
            // 
            this.namasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.HeaderText = "nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namasiswaDataGridViewTextBoxColumn.Name = "namasiswaDataGridViewTextBoxColumn";
            this.namasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggallahirDataGridViewTextBoxColumn
            // 
            this.tanggallahirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.HeaderText = "tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggallahirDataGridViewTextBoxColumn.Name = "tanggallahirDataGridViewTextBoxColumn";
            this.tanggallahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // agamaDataGridViewTextBoxColumn
            // 
            this.agamaDataGridViewTextBoxColumn.DataPropertyName = "agama";
            this.agamaDataGridViewTextBoxColumn.HeaderText = "agama";
            this.agamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agamaDataGridViewTextBoxColumn.Name = "agamaDataGridViewTextBoxColumn";
            this.agamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodejurusanDataGridViewTextBoxColumn
            // 
            this.kodejurusanDataGridViewTextBoxColumn.DataPropertyName = "kode_jurusan";
            this.kodejurusanDataGridViewTextBoxColumn.HeaderText = "kode_jurusan";
            this.kodejurusanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodejurusanDataGridViewTextBoxColumn.Name = "kodejurusanDataGridViewTextBoxColumn";
            this.kodejurusanDataGridViewTextBoxColumn.Width = 125;
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
            this.btnback.Location = new System.Drawing.Point(18, 625);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 35);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Kembali";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(505, 418);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(309, 514);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(112, 35);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(969, 418);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(741, 420);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 35);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // siswa_baruTableAdapter
            // 
            this.siswa_baruTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggallahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodejurusanDataGridViewTextBoxColumn;
    }
}