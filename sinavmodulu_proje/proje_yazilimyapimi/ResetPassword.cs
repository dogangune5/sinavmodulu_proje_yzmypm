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
        // SqlConnection con = new SqlConnection("Data Source=DEKSTOP-1VQ823J;Initial Catalog=kullanicibilgileri;Integrated Security=True");
        SqlConnection con = new SqlConnection("server=.;Initial Catalog=kullanicibilgileri;Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtResetPass.Text == txtResetPassVer.Text)

            {

                
                SqlCommand cmd = new SqlCommand("UPDATE newkullanici SET [password] = '" + txtResetPassVer.Text + "' WHERE username='" + username + "' ", con);


                con.Open();
                cmd.ExecuteNonQuery();

                

                MessageBox.Show("yenileme işlemi başarılı");

            }

            else

            {

                MessageBox.Show("iki şifre aynı değil lütfen kontrol edin");

            }
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            this.Hide();
            gecis.Show();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
