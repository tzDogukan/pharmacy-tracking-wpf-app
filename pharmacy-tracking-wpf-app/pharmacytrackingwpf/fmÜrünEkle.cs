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
    public partial class fmÜrünEkle : Form
    {
        public fmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void barkodnoEngelle()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from ürün", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString() ||txtBarkodNo.Text == "")
                {
                    durum = false;
                }
            }
            baglantı.Close();
        }
        private void fmÜrünEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void KategoriGetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglantı.Close();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+comboKategori.SelectedItem  +"'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglantı.Close();
        }

        private void btnYeniÜrünEkle_Click(object sender, EventArgs e)
        {
            barkodnoEngelle();
            if (durum == true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into ürün(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih) ", baglantı);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtÜrünMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyatı.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Yeni Ürün Başarıyla Eklendi");
                comboMarka.Items.Clear();
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Böyle bir barkod numarası var","Uyarı");
            }
            
        }

        private void voBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (voBarkodNo.Text == "")
            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from ürün where barkodno like '" + voBarkodNo.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                voKategori.Text = read["kategori"].ToString();
                voMarka.Text = read["marka"].ToString();
                voÜrünAdı.Text = read["urunadi"].ToString();
                lblMiktari.Text = read["miktari"].ToString();
                voAlışFiyatı.Text = read["alisfiyati"].ToString();
                voSatışFiyatı.Text = read["satisfiyati"].ToString();
            }
            baglantı.Close();
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update ürün set miktari=miktari+'"+int.Parse(voMiktarı.Text)+"'where barkodno= '"+voBarkodNo.Text +"'" ,baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürün Başarıyla Güncellendi");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
