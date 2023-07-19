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
    public partial class Form1 : Form
    {
        private string stringConnection = "data source=MAD\\MADDOG12;database=pendaftaran_siswa2;User ID=sa; Password=fiqi1234"; private SqlConnection koneksi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnJurusan_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnKelas_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
