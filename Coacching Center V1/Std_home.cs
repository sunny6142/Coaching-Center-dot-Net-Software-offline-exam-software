using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.Sql;
using System.Data.SqlClient;

namespace Coacching_Center_V1
{
    public partial class Std_home : Form
    {
        public Std_home()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                Form1.examcode = textBox1.Text.ToString();
                //   MessageBox.Show(Form1.examcode);
                ////////////////
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StartExam WHERE Examcode LIKE'" + Form1.examcode + "'", conn);

          //      MessageBox.Show("You are", "Message", MessageBoxButtons.OK);
                rdr = cmd.ExecuteReader();
            //    MessageBox.Show("You ", "Message", MessageBoxButtons.OK);
                rdr.Read();

             //        MessageBox.Show(rdr[0].ToString());
                if ((int)rdr[0] > 0)
                {
                    MessageBox.Show("You are Late , Exam is in Progress", "Message", MessageBoxButtons.OK);
                    return;
                }
              
               
            }
            catch (Exception ex) { MessageBox.Show("Server Problem : Contect Medcreador Team FOR HELP!"+ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            ////////////////////////////
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SELECT * FROM exam WHERE examcode='" + Form1.examcode + "'", conn);


                    rdr = cmd.ExecuteReader();
                    //    while(rdr.Read())
                    //     MessageBox.Show(rdr[0].ToString());
                    if (rdr.Read())
                    {
                        this.Hide();
                        Start st = new Start();
                        st.Show();
                    }
                    else MessageBox.Show("Check Your Examcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                ////////////

            }
            catch (Exception ex) { MessageBox.Show("Server Problem : Contect Medcreador Team FOR HELP!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            ///////////////////////////



        }

        private void Std_home_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.userid;
            label4.Text = Form1.username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
