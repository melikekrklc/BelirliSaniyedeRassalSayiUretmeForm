using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelirliSaniyedeRassalSayiUretmeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int min, max, saniye,sayi;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye == 0)
                this.Close();
            else
            {
                sayi = r.Next(min,max);
                label4.Text = sayi.ToString();
            }
        }
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(textBox1.Text);
            max = Convert.ToInt32(textBox2.Text);
            saniye = Convert.ToInt32(textBox3.Text);
            timer1.Enabled = true;
            


        }


    }
}
