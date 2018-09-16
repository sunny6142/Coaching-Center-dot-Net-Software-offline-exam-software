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
    public partial class Student_Result : Form
    {
        int Quesno = 0;
        string[] userid = new string[1000000];
        long i = 0;
        SqlCommand cmd;
        public Student_Result()
        {
            InitializeComponent();
        }

        private void Student_Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportData.Report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.reportData.Report);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter Exam code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");


            SqlDataReader rdr = null , rdr1 = null;
            try
            {                                                                                                                                                                                                                           
                conn.Open();

                     SqlCommand cmd2 = new SqlCommand("SELECT MAX(qno) FROM exam WHERE(examcode ='" + textBox1.Text.ToString() + "')", conn);
               
                  rdr1 = cmd2.ExecuteReader();
                //     MessageBox.Show("4"+ rdr1[0].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdr1.Read();
                Quesno = int.Parse(rdr1[0].ToString());
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errot S0001 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (rdr1 != null)
                {
                    rdr1.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }


            
            //////////////////////////////////////////////////////
            try
            {
                report1TableAdapter.DeleteQueryReport();
                // 2. Open the connection
                conn.Open();

             
                SqlCommand cmd = new SqlCommand("SELECT username, userid, marks, qno, correctness FROM Result WHERE(examcode ='"+ textBox1.Text.ToString()+"')", conn);

                rdr = cmd.ExecuteReader();
                i = 0;
                while (rdr.Read())
                {
                    report1TableAdapter.InsertQueryReport(rdr[0].ToString(), rdr[1].ToString(), double.Parse(rdr[2].ToString()), int.Parse(rdr[3].ToString()), int.Parse(rdr[4].ToString()), Quesno);
                    userid[i] = rdr[1].ToString();
                    i = i + 1;
                }
                //else
                //    MessageBox.Show("Dummy Ready", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Errot S9987 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            try
            {
                reportTableAdapter.DeleteQueryReport();
                
                long j = 0;
                while (j < i)
                {
                    conn.Open();
               //     MessageBox.Show("1" + userid[j], "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     cmd = new SqlCommand("SELECT username FROM dummy WHERE(userid LIKE'" + userid[j] + "')", conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    string name = rdr[0].ToString();
                    rdr.Close();

                    cmd = new SqlCommand("SELECT SUM(marks) FROM dummy WHERE(userid LIKE'" + userid[j] + "')", conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    double marks = (double)rdr[0];
                    rdr.Close();

                    cmd = new SqlCommand("SELECT COUNT(*)FROM dummy WHERE(userid LIKE'" + userid[j] + "')", conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    int quesatp = (int)rdr[0];
                    rdr.Close();

                    cmd = new SqlCommand("SELECT SUM(correctQues) FROM dummy WHERE(userid LIKE'" + userid[j] + "')", conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    int correctQues = (int)rdr[0];
                    rdr.Close();

                    cmd = new SqlCommand("SELECT totalquestion FROM dummy WHERE(userid LIKE'" + userid[j] + "')", conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    int totalquestion = (int)rdr[0];
                    rdr.Close();

                    ////////////////////////////////////////////////////////
                

           //             MessageBox.Show("1");
                        // 2. Open the connection
                     //   conn.Open();

                        // 3. Pass the connection to a command object
                        //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             //           MessageBox.Show("2");

                        cmd = new SqlCommand("SELECT COUNT(*) FROM Report WHERE userid LIKE'" + userid[j] + "'", conn);
                        //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //         MessageBox.Show("3");
                        rdr = cmd.ExecuteReader();
          //          MessageBox.Show("4");
                    rdr.Read();
            //            MessageBox.Show("5");
                        if ((int)rdr[0] > 0)
                        {

              //              MessageBox.Show("User id Already Exist" + rdr[0].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            reportTableAdapter.InsertQueryReport(name, userid[j], marks, quesatp, correctQues, totalquestion);
                        }
                        rdr.Close();
                    
                
                    //////////////////////////////////////////////////////

                   
                    j = j + 1;
                    conn.Close();
                }
                //else
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errot S9987 Reading Data Collapse"+ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

    //        this.reportTableAdapter.Fill(this.reportData.Report);
            this.reportTableAdapter.Fill(this.reportData.Report);
            
            this.reportViewer1.RefreshReport();
            this.reportTableAdapter.Fill(this.reportData.Report);
      //      MessageBox.Show("OK", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }
    }
}
