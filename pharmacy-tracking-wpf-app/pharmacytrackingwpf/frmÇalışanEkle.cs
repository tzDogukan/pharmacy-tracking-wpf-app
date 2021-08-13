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
    public partial class frmÇalışanEkle : Form
    {
        public frmÇalışanEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void frmÇalışanEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into çalışan(tc,adsoyad,telefon,adres,email,maas) values(@tc,@adsoyad,@telefon,@adres,@email,@maas) ", baglantı);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdres.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@maas", txtMaas.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Çalışan Kaydı Başarıyla Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
