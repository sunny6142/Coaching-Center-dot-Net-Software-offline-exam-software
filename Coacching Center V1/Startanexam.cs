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
    public partial class Startanexam : Form
    {
        SqlConnection conn;
        SqlDataReader rdr = null;
        public Startanexam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string examcode = textBox1.Text.ToString();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Examcode Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");
            rdr = null;

            try
            {
                conn.Open();
                
                //   MessageBox.Show(Form1.examcode);
                SqlCommand cmd = new SqlCommand("SELECT * FROM exam WHERE examcode='" + examcode + "'", conn);


                rdr = cmd.ExecuteReader();
                //    while(rdr.Read())
                //     MessageBox.Show(rdr[0].ToString());
             //   rdr.Read()
                if (rdr.Read())
                {
                    DialogResult result = MessageBox.Show("No Student Will be allowed for this Exam Once Start", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        startExamTableAdapter.InsertQuery(1, examcode);
                    }
                }
                else MessageBox.Show("Check Your Examcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void Startanexam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cCDataSet13.StartExam' table. You can move, or remove it, as needed.
         //   this.startExamTableAdapter.Fill(this.cCDataSet13.StartExam);
            // TODO: This line of code loads data into the 'cCDataSet12.exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.cCDataSet12.exam);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string examcode2 = textBox2.Text.ToString();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Examcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");
            rdr = null;

            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM StartExam WHERE examcode='" + examcode2 + "'", conn);


                rdr = cmd.ExecuteReader();
                //    while(rdr.Read())
                //     MessageBox.Show(rdr[0].ToString());
                //   rdr.Read()
                if (rdr.Read())
                {
                    DialogResult result = MessageBox.Show("No Student Will be allowed for this Exam Once Start", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        startExamTableAdapter.DeleteQuery(examcode2);
                    }
                }
                else MessageBox.Show("Check Your Examcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
