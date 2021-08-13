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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }
        private void SepetListele()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglantı);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglantı.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmÇalışanEkle ekle = new frmÇalışanEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmÇalışanListele listele = new frmÇalışanListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fmÜrünEkle ürün = new fmÜrünEkle();
            ürün.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmÜrünListeleme listele = new frmÜrünListeleme();
            listele.ShowDialog();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if(txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from müşteri where tc like '" + txtTc.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();

            }
            baglantı.Close();

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if ( item is TextBox)
                    {
                        if (item != txtMiktarı)
                        {
                            item.Text = "";
                        }
                    }
                    
                }

            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from ürün where barkodno like '" + txtBarkodNo.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdı.Text = read["urunadi"].ToString();
                txtSatışFiyatı.Text = read["satisfiyati"].ToString();
                txtToplamFiyat.Text = Convert.ToString(Convert.ToDouble(read["satisfiyati"].ToString()) * Convert.ToDouble(txtMiktarı.Text));
            }
            baglantı.Close();
        }

        private void txtMiktarı_TextChanged(object sender, EventArgs e)
        {
            if (txtSatışFiyatı.Text != "" && txtMiktarı.Text != "") 
            {
                txtToplamFiyat.Text = Convert.ToString(Convert.ToDouble(txtSatışFiyatı.Text) * Convert.ToDouble(txtMiktarı.Text));

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,ürünadı,miktari,satisfiyati,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@ürünadı,@miktari,@satisfiyati,@toplamfiyat,@tarih) ", baglantı);
            komut.Parameters.AddWithValue("@tc", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@ürünadı", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
            komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txtToplamFiyat.Text));
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglantı.Close();
            txtMiktarı.Text = "1";            
            daset.Tables["sepet"].Clear();
            SepetListele();

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktarı)
                        {
                            item.Text = "";
                        }
                    }

                }
            hesapla();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün sepetten çıkartıldı");
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();

        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürünler sepetten çıkartıldı");
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih) ", baglantı);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["ürünadı"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglantı.Close();
                baglantı.Open();
                SqlCommand komut2 = new SqlCommand("update ürün set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "'where barkodno= '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglantı);
                komut2.ExecuteNonQuery();
                baglantı.Close();
            }

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglantı);
            komut3.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
            MessageBox.Show("Satış Başarıyla Gerçekleştirildi");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet", baglantı);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglantı.Close();
            }
            catch(Exception)
            {
                ;
            }
        }
    }
}
