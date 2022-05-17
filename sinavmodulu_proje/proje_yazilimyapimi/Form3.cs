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
    public partial class Form3 : Form
    {

        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;


        public Form3()
        {
            InitializeComponent();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        } 



        // girilen bilgiler veri tabanı ile kontrol edildikten sonra giriş sağlanıyor
        private void button1_Click(object sender, EventArgs e)
        {
            {
                string user = txtadminadi.Text;
                string password = txtadminsifre.Text;
                baglanti = new SqlConnection("Data Source=DESKTOP-1VQ823J;Initial Catalog=kullanicibilgileri;Integrated Security=True");
                komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti; // yukarıda tanımlanan bağlantıyı al comut satırının bağlantısına ekle
                komut.CommandText = "select *from admin_bilgileri where adminname='" + txtadminadi.Text + "'And adminpassword='" + txtadminsifre.Text + " '";
                // kullanici_adi -- username     sifre-----userpassword     kullanici----admin_bilgileri

                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    // giriş başarılı ise yeni forma geçiyoruz
                    MessageBox.Show("Giriş başarılı !");
                    Form4 gecis = new Form4();
                    gecis.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı admin adı veya şifre !");
                }
                baglanti.Close();


            }
        }
        // önceki forma dönmek için butonumuz
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();
        }
    }
}
