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

namespace pharmacytrackingwpf
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void MarkaEngelle()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text == read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || textBox1.Text == "" || comboBox1.Text=="")
                {
                    durum = false;
                }
            }
            baglantı.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkaEngelle();
            if (durum == true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                textBox1.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Marka başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var","Uyarı");
            }
          
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglantı.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
