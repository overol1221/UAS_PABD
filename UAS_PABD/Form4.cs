using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UAS_PABD
{
    public partial class Form4 : Form
    {
        private string stringconnection = "data source=ALDAYANDAY\\ALDAYANDAY;database=gridform4;MultipleActiveResultSets=True;User ID=sa;Password=Unkown007";
        SqlConnection koneksi;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView();
            DisableControls();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string kj = txtkkodejrsn.Text;
            string nj = txtnamajrsn.Text;

            if (kj == "")
            {
                MessageBox.Show("Masukkan Kode Jurusan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nj == "")
            {
                MessageBox.Show("Masukkan Nama Jurusan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(stringconnection);
                koneksi.Open();
                string str = "INSERT INTO jurusan (kode_jurusan, nama_jurusan) VALUES (@KJ, @NJ)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@KJ", kj));
                cmd.Parameters.Add(new SqlParameter("@NJ", nj));

                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView(); 
            }
        }

        private void dataGridView()
        {
            koneksi = new SqlConnection(stringconnection);
            koneksi.Open();
            string query = "SELECT kode_jurusan, nama_jurusan FROM jurusan"; 
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedKodeJurusan = dataGridView1.SelectedRows[0].Cells["kode_jurusan"].Value.ToString();
                koneksi = new SqlConnection(stringconnection);
                koneksi.Open();
                string str = "DELETE FROM jurusan WHERE kode_jurusan = @KodeJurusan";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@KodeJurusan", selectedKodeJurusan));

                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void EnableControls()
        {

            btnSubmit.Enabled = true;
            btnBack.Enabled = true;
            txtkkodejrsn.Enabled = true;
            txtnamajrsn.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void DisableControls()
        {
            btnSubmit.Enabled = false;
            btnBack.Enabled = false;
            txtkkodejrsn.Enabled = false;
            txtnamajrsn.Enabled = false;
            dataGridView1.Enabled = false;
        }

    }
}
