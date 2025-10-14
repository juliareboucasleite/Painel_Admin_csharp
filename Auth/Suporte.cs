using System;
using System.Windows.Forms;

namespace Painel_Admin
{
    public partial class Suporte : Form
    {
        public Suporte()
        {
            InitializeComponent();
        }


        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/juliareboucasleite");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:suporte.promoping@gmail.com");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/351933992199"); // WhatsApp link
        }

        private void Suporte_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
