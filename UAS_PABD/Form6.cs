using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UAS_PABD
{
    public partial class Form6 : Form
    {
        Image CurImage;
        string curFileName;
        string connectionString = "data source=ALDAYANDAY\\ALDAYANDAY; database=ortumhs; MultipleActiveResultSets=True; User ID=sa; Password=Unkown007";
        string savedImageName = "";
        SqlConnection koneksi;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView();
            DisableControls();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;
                textBox1.Text = curFileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FileStream file = new FileStream(curFileName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] rawdata = new byte[file.Length];
                file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
                file.Close();

                string sql = "SELECT * FROM Mahasiswa";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet("Mahasiswa");
                adapter.Fill(ds, "Mahasiswa");

                DataRow row = ds.Tables["Mahasiswa"].NewRow();
                row["Nim"] = 1;
                row["Nama"] = "SQL";
                row["Foto"] = rawdata;
                ds.Tables["Mahasiswa"].Rows.Add(row);
                adapter.Update(ds, "Mahasiswa");
                connection.Close();

                MessageBox.Show("Image saved");
            }
            else
            {
                MessageBox.Show("Click the Browse button to select an image");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string sql = "SELECT Foto FROM Mahasiswa WHERE Nim='1'";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                FileStream file;
                BinaryWriter bw;
                int bufferSize = 100;
                byte[] outbyte = new byte[bufferSize];
                long retval;
                long startIndex = 0;
                savedImageName = textBox1.Text;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader myReader = command.ExecuteReader(CommandBehavior.SequentialAccess);
                while (myReader.Read())
                {
                    file = new FileStream(savedImageName, FileMode.OpenOrCreate, FileAccess.Write);
                    bw = new BinaryWriter(file);
                    startIndex = 0;
                    retval = myReader.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                    while (retval == bufferSize)
                    {
                        bw.Write(outbyte);
                        bw.Flush();
                        startIndex += bufferSize;
                        retval = myReader.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                    }
                    bw.Write(outbyte, 0, (int)retval);
                    bw.Flush();
                    bw.Close();
                    file.Close();
                }
                connection.Close();

                CurImage = Image.FromFile(savedImageName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Atur properti SizeMode menjadi Zoom
                pictureBox1.Image = CurImage;
                pictureBox1.Invalidate();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Upload the image first");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nik = txtnik.Text;
            string nma = txtnama.Text;
            string pkrjn = txtpkrjn.Text;

            if (nik == "")
            {
                MessageBox.Show("Masukkan NIK", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nma == "")
            {
                MessageBox.Show("Masukkan Nama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pkrjn == "")
            {
                MessageBox.Show("Masukkan Pekerjaan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(connectionString);
                koneksi.Open();
                string str = "INSERT INTO ortumhs (nik, nama, pekerjaan) VALUES (@NIK, @NAMA, @PK)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@NIK", nik));
                cmd.Parameters.Add(new SqlParameter("@NAMA", nma));
                cmd.Parameters.Add(new SqlParameter("@PK", pkrjn));

                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
            }

        }
        private void dataGridView()
        {
            koneksi = new SqlConnection(connectionString);
            koneksi.Open();
            string query = "SELECT nik, nama, pekerjaan FROM ortumhs";
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
                string selectedKodeJurusan = dataGridView1.SelectedRows[0].Cells["nik"].Value.ToString();
                koneksi = new SqlConnection(connectionString);
                koneksi.Open();
                string str = "DELETE FROM ortumhs WHERE nik = @NIK";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@NIK", selectedKodeJurusan));

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
            btnDelete.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            txtnama.Enabled = true;
            txtnik.Enabled = true;
            txtpkrjn.Enabled = true;
            textBox1.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void DisableControls()
        {
            btnSubmit.Enabled = false;
            btnBack.Enabled = false;
            btnDelete.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            txtnama.Enabled = false;
            txtnik.Enabled = false;
            txtpkrjn.Enabled = false;
            textBox1.Enabled = false;
            dataGridView1.Enabled = false;
        }
    }
}
