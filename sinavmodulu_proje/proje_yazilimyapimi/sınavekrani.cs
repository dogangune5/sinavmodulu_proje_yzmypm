using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_yazilimyapimi
{
    public partial class sınavekrani : Form
    {
        public sınavekrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  sinavCozmeEkrani gecis = new sinavCozmeEkrani();
            gecis.Show();
            this.Hide(); 
          */
        }
    }
}
