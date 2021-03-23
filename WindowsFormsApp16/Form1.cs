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

        void temizle()
        {
            txtİd.Text = "";
            txtName2.Text = "";
            txtSirname.Text = "";
            txtJobs.Text = "";
            txtSalary.Text = "";
            txtCities.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtName.Focus();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet.Table_1);

        }

       

        private void btnList_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet.Table_1);
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MERHABA ASJER");
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("insert into Table_1 (PerAd,PerSoyad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtName2.Text);
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtName2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSirname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtJobs.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
