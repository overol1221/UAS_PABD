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
    public partial class Form5 : Form
    {
        private string stringconnection = "data source=MAD\\MADDOG12;database=pendaftaran_siswa2;User ID=sa; Password=fiqi1234"; SqlConnection koneksi;
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

        }
    }
}
