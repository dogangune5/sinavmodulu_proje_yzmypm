using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlClient;

namespace proje_yazilimyapimi
{
    public partial class soruEkle : Form
    {
        string imagepath;
        SqlConnection baglanti;

        SqlCommand komut;
        // SqlConnection baglanti = new SqlConnection("server=.;Initial Catalog=kullanicibilgileri;Integrated Security=SSPI");
        public soruEkle()
        {
            InitializeComponent();
        }

        private void rtxtsoruaciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsoruekle_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resimler = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();







            SqlConnection baglanti = new SqlConnection("server=.;Initial Catalog=kullanicibilgileri;Integrated Security=SSPI");
           
            string sorgu = "INSERT INTO tblsorular (soruaciklama,Asikki,Bsikki,Csikki,Dsikki,sorucevap,resim) VALUES (@soruaciklama,@Asikki,@Bsikki,@Csikki,@Dsikki,@sorucevap,@resim) ";
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@soruaciklama", rtxtsoruaciklama.Text);
            komut.Parameters.AddWithValue("@Asikki", txtAsikki.Text);
            komut.Parameters.AddWithValue("@Bsikki", txtBsikki.Text);
            komut.Parameters.AddWithValue("@Csikki", txtCsikki.Text);
            komut.Parameters.AddWithValue("@Dsikki", txtDsikki.Text);
            //  komut.Parameters.AddWithValue("@resim", txtresim.Text);
            komut.Parameters.Add("@resim", SqlDbType.Image,resimler.Length).Value=resimler;
            komut.Parameters.AddWithValue("@sorucevap", comboBox1.Text);

            komut.ExecuteNonQuery();
           
            MessageBox.Show("soru başarıyla eklendi");
            baglanti.Close();
        }
        // resim ekleme butonum
        private void button1_Click(object sender, EventArgs e)
        {
            /*  openFileDialog1.ShowDialog();
              pictureBox1.ImageLocation = openFileDialog1.FileName;
              txtresim.Text = openFileDialog1.FileName; */




            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = " Jpeg Dosyaları(*.jpeg) |*.jpeg|   Jpg Dosyaları(*.jpg)|*.jpg| Png Dosyaları (*png)|*.png| Gif Dosyaları(*.gif)|*.gif| Tif Dosyaları(*.tif) |*.tif";

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }


        }
        // formlar arası geçiş butonum
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 gecis = new Form4();
            
            gecis.Show();
            this.Hide();
        }

        private void soruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
