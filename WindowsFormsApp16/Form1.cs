using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = FIRAT-PC\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet.Table_1);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet.Table_1);
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("insert into Table_1 (PerAd,PerSoyad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtName1.Text);
            komut.Parameters.AddWithValue("@p2", txtSirname.Text);
            //komut.Parameters.AddWithValue("@p3", txtCities.Text);
            //komut.Parameters.AddWithValue("@p4", txtSalary.Text);
            //komut.Parameters.AddWithValue("@p5", txtJobs.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("personel eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "False";
        }
    }
}
