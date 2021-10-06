using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int not1, not2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button1.Text = "Hesapla...";
            button2.Text = "X";

             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = ""; 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ort;
            not1 = Convert.ToInt32(textBox1.Text);
            if (not1 > 100  || not1 < 0)
            {
                textBox1.Text = "Hatalı  Giriş Yaptınız...";
                not1 = 0;
            }
            not2 = Convert.ToInt32(textBox2.Text);
            if (!((not2 >= 0) && (not2 <= 100)))
            {
                textBox2.Text = "Hatalı Giriş Yaptınız...";
                not2 = 0;

            }
            ort = ((Double)not1 + (Double)not2) / 2;
            if (ort >= 50)
                textBox3.Text = ort.ToString() + "Geçtiniz...";
            else
                textBox3.Text = ort.ToString() + "Kaldınız...";


               
                
                    
               
                


        }
    }
}
