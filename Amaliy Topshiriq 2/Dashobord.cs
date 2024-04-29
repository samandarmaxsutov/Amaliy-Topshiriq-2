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
    public partial class Dashobord : Form
    {
        public Dashobord()
        {
            InitializeComponent();
            this.VisibleChanged += Dashboard_VisibleChanged;
        }

        private void Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            // Only reload data when the form is actually visible
            if (this.Visible)
            {
                LoadData();
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }


        private void Dashobord_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global global = Global.getGlobal();
            global.GetForm1().Show();
            global.GetDashobord().Hide();
        }


        private void LoadData()
        {
            Global global = Global.getGlobal();

            // Ensure DataGridView exists
            if (dataGridView1 == null)
            {
                dataGridView1 = new DataGridView();
                this.Controls.Add(dataGridView1);
            }

            // Configure the DataGridView, if necessary
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Clear();
                string[] columnNames = { "ID", "Ism", "Familiya", "Yosh", "Login", "Parol" };
                foreach (string columnName in columnNames)
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = columnName,
                        HeaderText = columnName
                    });
                }
            }

            // Load or refresh data
            dataGridView1.Rows.Clear();
            if (global.studentsList != null)
            {
                foreach (var student in global.studentsList)
                {
                    dataGridView1.Rows.Add(
                        student.getId(),
                        student.getFirstName(),
                        student.getLastName(),
                        student.getAge(),
                        student.getLogin(),
                        student.getPassword()
                    );
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
