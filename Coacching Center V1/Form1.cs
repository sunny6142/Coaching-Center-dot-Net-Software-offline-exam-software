using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coacching_Center_V1
{
    public partial class Form1 : Form
    {
        public static string userid , username , examcode;
        public static int marks, qno;
        public static string correctoption;
        public Form1()
        {
            InitializeComponent();
          //  SqlConnection conn = new SqlConnection("Data Source=192.168.43.185,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           
          //  return;
            using (CCEnt context = new CCEnt())
            {
                context.Database.Connection.Open();
               // context.Connection.Open();
                // the rest
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter User_id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            try
            {
                using (CCEnt CC = new CCEnt())
                {
                    var query = from o in CC.login_info
                                where o.userid == textBox1.Text && o.name == textBox2.Text
                                select o;

                    if(query.SingleOrDefault() != null)
                    {
                        this.Hide();
//                        MessageBox.Show("Successfully Login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userid = textBox1.Text;
                        username = textBox2.Text;
                        Std_home home = new Std_home();
                        home.Show();
                    }
                    else
                    {
                        if((string)textBox1.Text == "admin" && (string)textBox2.Text == "admin")
                        {
                               this.Hide();
                            Admin admin = new Admin();
                            admin.Show();
                           // Application.Run(admin);
                            //this.Close();
                        }
                        else
                        MessageBox.Show("Check Your User Name or password","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1.PerformClick();
        }
    }
}
