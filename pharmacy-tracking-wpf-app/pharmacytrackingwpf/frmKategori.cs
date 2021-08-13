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
namespace pharmacytrackingwpf
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void KategoriEngelle()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri",baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() || textBox1.Text =="")
                {
                    durum = false;
                }
            }
            baglantı.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KategoriEngelle();
            if(durum == true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + textBox1.Text + "')", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                textBox1.Text = "";
                MessageBox.Show("Kategori başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori var", "Uyarı");
            }
            textBox1.Text = "";
        }
    }
}
