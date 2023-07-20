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
        string connectionString = "data source=ALDAYANDAY\\ALDAYANDAY; database=BLOB; MultipleActiveResultSets=True; User ID=Sa; Password=Unkown007";
        string savedImageName = "";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

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
    }
}
