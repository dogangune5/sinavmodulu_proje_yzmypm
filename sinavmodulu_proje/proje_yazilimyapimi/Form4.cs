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

        
        // formlar arası geçiş için butonlarımız

        private void btnkullanici_islemleri_Click(object sender, EventArgs e)
        {        // form arası geçiş butonumuz
             Kullanici_islemleri gecis = new Kullanici_islemleri();
            gecis.Show();
             this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { // form arası geçiş butonumuz
            Form3 gecis = new Form3();
            gecis.Show();
            this.Hide();
        }

        private void btnsoruislemleri_Click(object sender, EventArgs e)
        {
            soruEkle gecis = new soruEkle();
            this.Hide();
            gecis.Show();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {

        } 

    }
}
