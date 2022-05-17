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

namespace proje_yazilimyapimi
{
    public partial class Kullanici_islemleri : Form
    {
       
        public Kullanici_islemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;
        SqlDataAdapter da;

        void Kullanicigetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=kullanicibilgileri;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM newkullanici", baglanti);
            DataTable tablo = new DataTable();
            // tabloyu dolduralım
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO newkullanici(username,password) VALUES (@username,@password) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@password", txtSifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kullanicigetir();
        }

        private void Kullanici_islemleri_Load(object sender, EventArgs e)
        {
            Kullanicigetir();
        }
        // VERİLER VERİ TABANINDAN ÇEKER 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        // KULLANICI SİLME İŞLEMLERİNİ GERÇEKLEŞTİRİR
        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM newkullanici WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kullanicigetir();
        }
        // KULLANICI GÜNCELLEME İŞLEMLERİNİ GERÇEKLEŞTİRİR
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE newkullanici SET username=@username,password=@password WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@password", txtSifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kullanicigetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 gecis = new Form4();
            gecis.Show();
            this.Hide();
        }
    }
}
