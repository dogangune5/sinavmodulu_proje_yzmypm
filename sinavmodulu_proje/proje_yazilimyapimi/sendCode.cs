using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace proje_yazilimyapimi
{
    public partial class sendCode : Form
    {
        string randomCode;

        public static string to;



        public sendCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // kullanıcıya e mail yollamak için kod bloğumuz 

            string from, pass, messageBody;
            
            Random rand = new Random();
            
            randomCode = (rand.Next(999999)).ToString();
            
            MailMessage message = new MailMessage();

            from = "havadayokk12@gmail.com";
            
            pass = "Dgns2461.";
            
            messageBody = "yenileme kodunuz " + randomCode;
            to = txtEmail.Text;
            message.To.Add(to);
            
            message.From = new MailAddress(from);
            
            message.Body = messageBody;
            
            message.Subject = "şifre sıfırlama kodu";
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            
            smtp.EnableSsl = true;
            
            smtp.Port = 587;
            
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            
            smtp.Credentials = new NetworkCredential(from, pass);
            
            try

            {
                
            smtp.Send(message);
                
            MessageBox.Show("kod başarıyla yollandı");
                
            }
            
            catch (Exception ex)

            {
                
            MessageBox.Show(ex.Message);
                
            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
                
            {
                
            to = txtEmail.Text;
                
            ResetPassword rp = new ResetPassword();
               
            this.Hide();
                
            rp.Show();
                
            }
            
            else
                
            {
                
            MessageBox.Show("hatalı kod");
                
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }
    }
}
