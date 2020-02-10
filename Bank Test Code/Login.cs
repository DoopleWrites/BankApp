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

        private void label3_Click_1(object sender, EventArgs e)
        {

            Globals.userName = textBox1.Text;
            Globals.enteredPassword = textBox2.Text;


            if (Globals.userName == "Username" || Globals.enteredPassword == "Password")
            {
                MessageBox.Show("Please enter Username and Password", "Username and Password invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            if (Globals.userName == "" || Globals.enteredPassword == "")
            {
                MessageBox.Show("Please enter Username and Password", "Username and Password invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> userNames = File.ReadLines(@"C:\\Users\Admin\source\repos\Bank Test Code\Bank Test Code\Users.txt").ToList();
            List<string> passwordsList = File.ReadLines(@"C:\\Users\Admin\source\repos\Bank Test Code\Bank Test Code\Passwords.txt").ToList();

            if (userNames.Contains(Globals.userName) && passwordsList.Contains(Globals.enteredPassword))
            {
                Home f2 = new Home();
                this.Hide();
                f2.ShowDialog();
                this.Close();
                
            }
            else MessageBox.Show("Invalid username or Password", "Invalid username/password", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            panel1.Top += 15;
            panel8.Top += 15;

            if (panel8.Top <= 424 )
            {
                timer3.Stop();
            }

        }
    }
    static class Globals
    {
        public static string userName;
        public static string enteredPassword;
    }
}
