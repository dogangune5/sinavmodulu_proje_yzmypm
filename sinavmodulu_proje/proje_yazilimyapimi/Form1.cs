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
    public partial class Form1 : Form
    {
        
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;
       
       
        

         




        public string conString = "Data Source=DESKTOP-1VQ823J;Initial Catalog=kullanicibilgileri;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            string user = txtkullanici.Text;
            string password = txtsifre.Text;
            baglanti = new SqlConnection("Data Source=DESKTOP-1VQ823J;Initial Catalog=kullanicibilgileri;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti; // yukarýda tanýmlanan baðlantýyý al comut satýrýnýn baðlantýsýna ekle
            komut.CommandText = "select *from newkullanici where username='" + txtkullanici.Text + "'And password='" + txtsifre.Text + " '";
            // kullanici_adi -- username     sifre-----userpassword     kullanici----newkullanici

            dr = komut.ExecuteReader();
            if (dr.Read())
            {
               
                MessageBox.Show("Giriþ baþarýlý!");
               // Form2 gecis = new Form2();
               // gecis.Show();
               // this.Hide();



            }
        else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre !");
            }
            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sendCode sc = new sendCode();
            this.Hide();
            sc.Show();
        }
    }
}