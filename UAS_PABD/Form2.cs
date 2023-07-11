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
        private string stringConnection = "data source=MAD\\MADDOG12;database=pendaftaran_siswa2;User ID=sa; Password=fi1234"; private SqlConnection koneksi;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pendaftaran_siswa2DataSet.siswa_baru' table. You can move, or remove it, as needed.
            this.siswa_baruTableAdapter.Fill(this.pendaftaran_siswa2DataSet.siswa_baru);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
