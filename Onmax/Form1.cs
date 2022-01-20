using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Guna.UI2;

namespace Onmax
{
    public partial class Onmax : Form
    {
        public Onmax()
        {
            InitializeComponent();
            

        }

        private void Onmax_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this); /* Cień Okna */
            timer1.Start();
            actualtime.Text = DateTime.Now.ToLongTimeString();
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_sekundy.Text == "")
                {
                    tb_sekundy.Text = "0";
                }

                lab_godz1.Text = (int.Parse(tb_sekundy.Text) / 60 / 60 + " godz.").ToString();
                lab_min1.Text = (int.Parse(tb_sekundy.Text) % 3600 / 60 + " min.").ToString();
                lab_sekundy.Text = (int.Parse(tb_sekundy.Text) + " sek.").ToString();
                lab_godz2.Text = (int.Parse(tb_sekundy.Text) / 60 / 60 + " godz.").ToString();

                tb_godziny.Text = (int.Parse(tb_sekundy.Text) / 60 / 60).ToString();
                tb_minuty.Text = (int.Parse(tb_sekundy.Text) % 3600 / 60).ToString();
                tb_minuty2.Text = (int.Parse(tb_sekundy.Text) / 60).ToString();
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Sprawdź poprawność danych, litery czy znaki nie są akceptowane oraz pamiętaj że pole nie może pozostać puste!", "Uwaga",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void tb_godziny_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_minuty_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_minuty2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                lab_sekundy.Text = (int.Parse(tb_godziny.Text) * 60 * 60 + int.Parse(tb_minuty.Text) * 60).ToString();
                lab_godz1.Text = (int.Parse(lab_sekundy.Text) / 60 / 60).ToString();
                lab_min1.Text = (int.Parse(lab_sekundy.Text) % 3600 / 60).ToString();
                lab_godz2.Text = (int.Parse(lab_sekundy.Text) / 60 / 60).ToString();
                tb_sekundy.Text = (int.Parse(tb_godziny.Text) * 60 * 60 + int.Parse(tb_minuty.Text) * 60).ToString();
            }
            catch 
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Sprawdź poprawność danych, litery czy znaki nie są akceptowane oraz pamiętaj że pole nie może pozostać puste!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                lab_godz2.Text = (int.Parse(tb_minuty2.Text) / 60).ToString();
                lab_sekundy.Text = (int.Parse(tb_minuty2.Text) * 60).ToString();
                lab_godz1.Text = (int.Parse(tb_minuty2.Text) / 60).ToString();
                tb_sekundy.Text = (int.Parse(tb_minuty2.Text) * 60).ToString();
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Sprawdź poprawność danych, litery czy znaki nie są akceptowane oraz pamiętaj że pole nie może pozostać puste!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Show();
        }
    }
}
