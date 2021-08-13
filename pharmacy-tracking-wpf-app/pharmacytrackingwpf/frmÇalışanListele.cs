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
    public partial class frmÇalışanListele : Form
    {
        public frmÇalışanListele()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmÇalışanListele_Load(object sender, EventArgs e)
        {
            KayıtGöster();

        }
        private void KayıtGöster()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from çalışan", baglantı);
            adtr.Fill(daset, "çalışan");
            dataGridView1.DataSource = daset.Tables["çalışan"];
            baglantı.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from çalışan where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["çalışan"].Clear();
            KayıtGöster();
            MessageBox.Show("Çalışan Başarıyla Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update çalışan set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email ,maas=@maas where tc=@tc", baglantı);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdres.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@maas", txtMaas.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["çalışan"].Clear();
            KayıtGöster();
            MessageBox.Show("Çalışan Kaydı Başarıyla Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["maas"].Value.ToString();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from çalışan where tc like '%" + txtTcAra.Text + "%'", baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }
    }
}
