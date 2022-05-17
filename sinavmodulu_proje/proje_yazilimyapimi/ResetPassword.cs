using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace proje_yazilimyapimi
{
    public partial class ResetPassword : Form

    

    {
        
        
        string username = sendCode.to;

        public ResetPassword()
        {
            InitializeComponent();
        }
        // SQL BAĞLANTIMIZI KURDUK 
        // SqlConnection con = new SqlConnection("Data Source=DEKSTOP-1VQ823J;Initial Catalog=kullanicibilgileri;Integrated Security=True");
        SqlConnection con = new SqlConnection("server=.;Initial Catalog=kullanicibilgileri;Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtResetPass.Text == txtResetPassVer.Text)

            {

                // veritabanı kommutuzu yazdık
                SqlCommand cmd = new SqlCommand("UPDATE newkullanici SET [password] = '" + txtResetPassVer.Text + "' WHERE username='" + username + "' ", con);


                con.Open(); // veritabanı bağlantısını açtık
                cmd.ExecuteNonQuery();

                

                MessageBox.Show("yenileme işlemi başarılı");

            }

            else

            {

                MessageBox.Show("iki şifre aynı değil lütfen kontrol edin");

            }
            con.Close(); // veritabanı bağlantısını kapattık

        }

        private void label3_Click(object sender, EventArgs e)
        { // ŞİFRE YENİLENDİKTEN SONRA GİRİŞ YAP KISMINA GEÇİRİR
            Form1 gecis = new Form1();
            this.Hide();
            gecis.Show();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
