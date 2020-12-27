using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorun = 0, dogru = 0, yanlış = 0;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lbly.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lbly.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lbly.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lbly.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btns_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btns.Enabled = false;



            sorun++;
            lbls.Text = sorun.ToString();

            if (sorun == 1)
            {
                richTextBox1.Text = "Cumhuriyet ilan yılı";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";
                pictureBox1.Visible = false;
                pictureBox1.Visible = false;

            }
            if (sorun == 2)
            {
                richTextBox1.Text = "Hangisi Egededir";
                btna.Text = "İzmir";
                btnb.Text = "Ankara";
                btnc.Text = "Van";
                btnd.Text = "Samsun";
                label4.Text = "İzmir";

                pictureBox1.Visible = false;
                pictureBox1.Visible = false;

            }
            if (sorun == 3)
            {
                richTextBox1.Text = "Hangisi En hızlıdır";
                btna.Text = "Araba";
                btnb.Text = "Uçak";
                btnc.Text = "Mazda RX8";
                btnd.Text = "Işık";
                label4.Text = "Mazda RX8";

                pictureBox1.Visible = false;
                pictureBox1.Visible = false;

                btns.Text = "Sonuçlar";
            }
            if (sorun == 4)
            {
                btna.Visible = false;
                btnb.Visible = false;
                btnc.Visible = false;
                btnd.Visible = false;
                btns.Visible = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlış);
            }

        }
    }
}
