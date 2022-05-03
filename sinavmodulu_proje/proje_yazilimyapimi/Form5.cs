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
    public partial class Form5 : Form
    {

        
        public Form5()
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

        
        private void Form5_Load(object sender, EventArgs e)
        {
            Kullanicigetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             txtkullaniciadikayit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsifrekayit.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
          
            string sorgu = "INSERT INTO newkullanici(username,password) VALUES (@username,@password) ";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@username", txtkullaniciadikayit.Text);
            komut.Parameters.AddWithValue("@password", txtsifrekayit.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kullanicigetir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM newkullanici WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            
            komut.Parameters.AddWithValue("@id",Convert.ToInt32(txtid.Text)); 
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kullanicigetir();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE newkullanici SET username=@username,password=@password WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@username", txtkullaniciadikayit.Text);
            komut.Parameters.AddWithValue("@password", txtsifrekayit.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kullanicigetir();
        
           
        }
    }
}
