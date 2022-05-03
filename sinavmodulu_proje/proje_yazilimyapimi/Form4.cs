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
    public partial class Form4 : Form
 {
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;
        SqlDataAdapter da;



        public Form4()
        {
            InitializeComponent();
        }

        


        private void btnkullanici_islemleri_Click(object sender, EventArgs e)
        {
            // Kullanicigetir();
            Form5 gecis = new Form5();
            gecis.Show();
            this.Hide();

        }
    }
}
