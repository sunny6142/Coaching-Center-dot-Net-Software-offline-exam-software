using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coacching_Center_V1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            set SET= new set();
            this.Hide();
            SET.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // using () ;
            button1.FlatAppearance.BorderSize = 0;
            Student_Result sr = new Student_Result();
            this.Hide();
            sr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            AddStudent AD = new AddStudent();
            this.Hide();
            AD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.Green;
            button1.FlatAppearance.BorderSize = 4;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 3;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatAppearance.BorderSize = 4;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 3;
        }
        

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderColor = Color.Green;
            button3.FlatAppearance.BorderSize = 4;
        }

        

       

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 3;
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.Green;
            button1.FlatAppearance.BorderSize = 4;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 3;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Startanexam st = new Startanexam())
            {
                st.ShowDialog();
            }
        }
    }
}
