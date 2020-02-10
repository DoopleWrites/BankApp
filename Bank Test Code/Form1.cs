using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Test_Code
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text =="Register")
            {
                timer1.Start();
            }
            else if(button1.Text =="Login")
            {
                timer2.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel1.Left -= 15;
            panel4.Left -= 15;
            if (panel4.Left <= 12)
            {
                timer1.Stop();
                button1.Text = "Login";
                button1.BackColor = Color.FromArgb(78, 88, 169);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Left += 15;
            panel4.Left += 15;
            if (panel1.Left >= 12)
            {
                timer2.Stop();
                button1.Text = "Register";
                button1.BackColor = Color.FromArgb(254, 206, 0);
            }
        }
    }
}
