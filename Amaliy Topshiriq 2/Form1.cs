using Amaliy_Topshiriq_2.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amaliy_Topshiriq_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global global = Global.getGlobal();
            global.GetSignUpScreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text.ToString();
            String password = textBox2.Text.ToString();
            Global global = Global.getGlobal();
            if (global.FindStudent(password, login) == null)
            {
                MessageBox.Show("Paroll yoki Login xato!!");
            }
            else
            {
                this.Hide();
                global.GetDashobord().Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
