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

namespace UAS_PABD
{
    public partial class Form2 : Form
    {
        private string stringconnection = "data source=MAD\\MADDOG12;database=pendaftaran_siswa2;User ID=sa; Password=fiqi1234"; SqlConnection koneksi;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EnableControls();


        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void EnableControls(object sender, EventArgs e)
        {

            txtnis.Enabled = true;
            txtnamasiswa.Enabled = true;
            txttgllhr.Enabled = true;
            txtjk.Enabled = true;
            txtalamat.Enabled = true;
            txtagama.Enabled = true;
            txtkj.Enabled = true;
            btnAdd.Enabled = true;
            btnOpen.Enabled = true;
            btnSimpan.Enabled = true;
            btnClear.Enabled = true;
        }

        private void DisableControls(object sender, EventArgs e)
        {

            txtnis.Enabled = false;
            txtnamasiswa.Enabled = false;
            txttgllhr.Enabled = true;
            txtjk.Enabled = true;
            txtalamat.Enabled = true;
            txtagama.Enabled = true;
            txtkj.Enabled = true;
            btnAdd.Enabled = true;
            btnOpen.Enabled = true;
            btnSimpan.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nis = txtnis.Text;
            string namasiswa = txtnamasiswa.Text;
            string tgllhr = txttgllhr.Text;
            string jk = txtjk.Text;
            string alamat = txtalamat.Text;
            string agama = txtagama.Text;
            string kj = txtkj.Text;

            if (nis =="")
            {
                MessageBox.Show("Masukkan nis","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (namasiswa =="")
            {
                MessageBox.Show("Masukkan namasiswa","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tgllhr =="")
            {
                MessageBox.Show("Masukkan tanggal lahir","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (jk =="")
            {
                MessageBox.Show("Masukkan jenis kelamin","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (alamat =="")
            {
                MessageBox.Show("Masukkan alamat","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (agama =="")
            {
                MessageBox.Show("Masukkan agama","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kj =="")
            {
                MessageBox.Show("Masukkan kode kelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(stringconnection);
                koneksi.Open();
                string str = "INSERT INTO siswa_baru(nis,namasiswa,tgllhr,jk,alamat,agama,kj) VALUES (@Nis,@Namasiswa,@Tgllhr,@Jk,@Alamat,@Agama,@Kj)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nis", nis));
                cmd.Parameters.Add(new SqlParameter("@Namasiswa", namasiswa));
                cmd.Parameters.Add(new SqlParameter("@Tgllhr", tgllhr));
                cmd.Parameters.Add(new SqlParameter("@Jk", jk));
                cmd.Parameters.Add(new SqlParameter("@Alamat", alamat));
                cmd.Parameters.Add(new SqlParameter("@Agama", agama));
                cmd.Parameters.Add(new SqlParameter("@Kj", kj));

                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan","Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1();
                refreshform();
            }
        }
        private void refreshform()
            {
            txtnis.Text = "";
            txtnamasiswa.Text = "";
            txttgllhr.Text = "";
            txtjk.Text = "";
            txtalamat.Text = "";
            txtagama.Text = "";
            txtkj.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void dataGridView1()
        {
            koneksi = new SqlConnection(stringconnection);
            koneksi.Open();
            string query = "SELECT Nis,Namasiswa,Tgllhr,Jk,Alamat,Agama,Kj FROM dbo.siswa_baru";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string selectedKodeJurusan = dataGridView.SelectedRows[0].Cells["nis"].Value.ToString();
                koneksi = new SqlConnection(stringconnection);
                koneksi.Open();
                string str = "DELETE FROM siswa_baru WHERE nis = @NIS";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@NIS", selectedKodeJurusan));

                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1();
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
