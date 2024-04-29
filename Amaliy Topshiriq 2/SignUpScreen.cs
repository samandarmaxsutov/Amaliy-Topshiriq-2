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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Amaliy_Topshiriq_2
{
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Global global =  Global.getGlobal();
            global.GetForm1().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global global = Global.getGlobal();

            StudentDataClass studentDataClass = new StudentDataClass();
            studentDataClass.setID(0);
            studentDataClass.setName(textBoxISM.Text.ToString());
            studentDataClass.setLastName(textBoxFamiliya.Text.ToString());
            if (int.TryParse(textBoxYosh.Text, out int age))
            {
                studentDataClass.setAge(age);
            }
            else
            {
                MessageBox.Show("Yoshni to'g'tri kiriting!!");
                return;
            }
            studentDataClass.setLogin(textBoxLogin.Text.ToString());
            studentDataClass.setPassword(textBoxParol.Text.ToString());

            global.addStudent(studentDataClass);

          

            MessageBox.Show(studentDataClass.getFirstName().ToString() + " ro'yhatdan o'tdi");
            textBoxISM.Text = "";
            textBoxFamiliya.Text = "";
            textBoxYosh.Text = "";
            textBoxParol.Text = "";
            textBoxLogin.Text = "";
            global.GetForm1().Show();
            this.Hide();

           

        }

            private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
