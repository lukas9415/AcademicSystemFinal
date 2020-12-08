using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
using AcademicSystem;


namespace LoginApp
{

    public partial class Form1 : Form
    {

        public static User LoggedInUser;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersRepository repository = new UsersRepository();
            try
            {
                Form1.LoggedInUser = repository.Login(textBox1.Text, textBox2.Text);
                MainWindow g = new MainWindow();
                g.Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
