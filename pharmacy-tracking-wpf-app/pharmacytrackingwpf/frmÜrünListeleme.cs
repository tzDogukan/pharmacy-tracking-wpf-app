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
    public partial class frmÜrünListeleme : Form
    {
        public frmÜrünListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void frmÜrünListeleme_Load(object sender, EventArgs e)
        {
            KayıtGöster();
            KategoriGetir();
        }
        private void KayıtGöster()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from ürün", baglantı);
            adtr.Fill(daset, "ürün");
            dataGridView1.DataSource = daset.Tables["ürün"];
            baglantı.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            voBarkodNo.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            voKategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            voMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            voÜrünAdı.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            voMiktarı.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            voAlışFiyatı.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            voSatışFiyatı.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
            kayıttarihi.Text = dataGridView1.CurrentRow.Cells["tarih"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update ürün set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglantı);
            komut.Parameters.AddWithValue("@urunadi", voÜrünAdı.Text);
            komut.Parameters.AddWithValue("@barkodno", voBarkodNo.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(voMiktarı.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(voAlışFiyatı.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(voSatışFiyatı.Text));
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["ürün"].Clear();
            KayıtGöster();
            MessageBox.Show("Ürün Kaydı Başarıyla Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void KategoriGetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());
            }
            baglantı.Close();
        }
        private void katmargüncelle_Click(object sender, EventArgs e)
        {
            if(voBarkodNo.Text != "")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("update ürün set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglantı);
                komut.Parameters.AddWithValue("@kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@marka", combomarka.Text);
                komut.Parameters.AddWithValue("@barkodno", voBarkodNo.Text);

                komut.ExecuteNonQuery();
                baglantı.Close();
                daset.Tables["ürün"].Clear();
                KayıtGöster();
                MessageBox.Show("Güncelleme Başarıyla Güncellendi");
                foreach (Control item in this.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("BarkodNo yazılı değil");
            }
           
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarka.Items.Clear();
            combomarka.Text = "";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+ combokategori.Text +"'",baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());
            }
            baglantı.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from ürün where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["ürün"].Clear();
            KayıtGöster();
            MessageBox.Show("Ürün Başarıyla Silindi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from ürün where barkodno like '%" + textBox1.Text + "%'", baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

        private void voBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
