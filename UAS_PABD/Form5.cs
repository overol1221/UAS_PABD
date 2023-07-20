using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace UAS_PABD
{
    public partial class Form5 : Form
    {
        private string stringconnection = "data source=ALDAYANDAY\\ALDAYANDAY;database=gridform5;MultipleActiveResultSets=True;User ID=sa;Password=Unkown007";
        SqlConnection koneksi;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView();
            DisableControls();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string kk = txtkodekls.Text;
            string kj = txtkj.Text;

            if (kk == "")
            {
                MessageBox.Show("Masukkan Kode Kelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kj == "")
            {
                MessageBox.Show("Masukkan Kode Jurusan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(stringconnection);
                koneksi.Open();
                string str = "INSERT INTO kelas (kode_kelas, kode_jurusan) VALUES (@KK, @KJ)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@KK", kk));
                cmd.Parameters.Add(new SqlParameter("@KJ", kj));

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
            string query = "SELECT kode_kelas, kode_jurusan FROM kelas";
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
                string selectedKodeJurusan = dataGridView1.SelectedRows[0].Cells["kode_kelas"].Value.ToString();
                koneksi = new SqlConnection(stringconnection);
                koneksi.Open();
                string str = "DELETE FROM kelas WHERE kode_kelas = @KodeKelas";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@KodeKelas", selectedKodeJurusan));

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
            txtkodekls.Enabled = true;
            txtkj.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void DisableControls()
        {
            btnSubmit.Enabled = false;
            btnBack.Enabled = false;
            txtkodekls.Enabled = false;
            txtkj.Enabled = false;
            dataGridView1.Enabled = false;
        }
    }
}
