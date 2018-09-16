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
   
    public partial class ques : Form
    {

        SqlConnection conn; 
        int noq;
        int q = 1;
        string examcode, username, userid;
        int  correctness;
        string correctoption;
        double totalmarks;
        int s, h, m;
        double negmarks = 0 , marks;
        string time;
        SqlDataReader rdr = null;
        public ques()
        {
            InitializeComponent();

            this.titleTableAdapter.FillBytile(this.examtile.title, Form1.examcode);

            conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");

            this.titleTableAdapter.FillBytile(this.examtile.title, Form1.examcode);

            if (q == 1)
                button6.Hide();

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Expr1 FROM exam WHERE examcode ='"+Form1.examcode+"'", conn);

               
                rdr = cmd.ExecuteReader();
               
                while (rdr.Read())
                {
                     // MessageBox.Show(count.ToString());
             //       MessageBox.Show(rdr[0].ToString());
                    noq = (int)rdr[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Problem S888618", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            int j = 1, k =0;
            for (int i = 1; i <= noq; i++)
            {
                Button button = new Button();
                button.Location = new Point(1000 + 30*k, 30 * j + 120);
                button.Click += new EventHandler(ButtonClickOneEvent);
                button.Tag = i;
                button.Text = i.ToString();
                button.Size = new Size(28, 23);
                this.Controls.Add(button);
                
                if (k == 3) j++;
                k++;
                if (k == 4) k = 0;
            }
        }

      
        void ButtonClickOneEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                 q = (int)button.Tag;
                if (q == 1)
                {
                    button6.Hide();
                }
                else
                {
                    button6.Show();
                }
                if(q == noq)
                {
                    button1.Hide();
                }
                else
                {
                    button1.Show();
                }   
                    
                button.BackColor = Color.LightSkyBlue;
                Change();
            }
        }
        private void ques_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examtile.title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.FillBytile(this.examtile.title,Form1.examcode);
            // TODO: This line of code loads data into the 'cCDataSet8.StudentData' table. You can move, or remove it, as needed.
            //    this.studentDataTableAdapter1.Fill(this.cCDataSet8.StudentData);
            // TODO: This line of code loads data into the 'cCDataSet1.Result' table. You can move, or remove it, as needed.
            //  this.resultTableAdapter.Fill(this.cCDataSet1.Result);
            //   int s = 2;
            // TODO: This line of code loads data into the 'cCDataSet9.StudentData' table. You can move, or remove it, as needed.
            //  this.studentDataTableAdapter.Fill(this.cCDataSet9.StudentData);

            userid = Form1.userid;
            username = Form1.username;
            examcode = Form1.examcode;
            q = 1;
            Change();
            if (q == 1)
                button6.Hide();
            conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");

          

            SqlDataReader rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SqlCommand cmd = new SqlCommand("SELECT time FROM exam WHERE examcode ='" + Form1.examcode + "' And qno = '" + q + "'", conn);
                //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                  
                    time = rdr[0].ToString();
                 //   MessageBox.Show(time.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Time is not avaliable", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Able to Read Time", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            h = int.Parse(time) / 60;
            m = int.Parse(time) % 60;
            s = 0;
            timer1.Start();
        }


        public void Change()
        {
            cCoption.Clear();
            //    this.examTableAdapter.FillByques(this.cCDataSet.exam, q);
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            examTableAdapter.FillByques(this.cCDataSet.exam, q , Form1.examcode);
         

            
           this.exam2TableAdapter1.FillA(this.cCoption.exam2, q, Form1.examcode);
            this.exam3TableAdapter1.Fillb(this.cCoption.exam3, q, Form1.examcode);
            this.exam4TableAdapter1.Fillc(this.cCoption.exam4, q, Form1.examcode);
            this.exam1TableAdapter1.Filld(this.cCoption.exam1, q, Form1.examcode);
            groupBox1.Text = "Ques no. " + q.ToString();

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT marks , negmarks FROM exam WHERE examcode ='" + Form1.examcode.ToString() + "' And qno = '" + q + "'", conn);
                //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SqlDataReader rdr = cmd.ExecuteReader();
                //  MessageBox.Show("1", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (rdr.Read())
                {
                    //       MessageBox.Show(rdr[0].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //       MessageBox.Show(rdr[1].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //      MessageBox.Show("2", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    marks = (double)rdr[0];
                    //      MessageBox.Show("3", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    negmarks = (double)rdr[1];
                    //        MessageBox.Show(rdr[1].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label11.Text = rdr[0].ToString();
                    label9.Text = rdr[1].ToString();
                }
              //  else
               //     MessageBox.Show("Error S001 Reading Data label11", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("Error S088 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");


             rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SqlCommand cmd = new SqlCommand("SELECT selectedoption FROM Result WHERE examcode ='" + Form1.examcode + "' And qno = '" + q + "' And userid = '"+Form1.userid + "'", conn);
                //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string soption = (string)rdr[0];
                    if (soption == "a") checkBox1.Checked = true;
                    else if (soption == "b") checkBox3.Checked = true;
                    else if (soption == "c") checkBox2.Checked = true;
                    else if (soption == "d") checkBox4.Checked = true;
                }
           //     else
              //      MessageBox.Show("Error S002 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Check Your Examcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
    }

        private void fillByquesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                 cCoption.Clear();
        //        q = (int)(System.Convert.ChangeType(qnoToolStripTextBox.Text, typeof(int)));
          //      this.examTableAdapter.FillByques(this.cCDataSet.exam ,((int)(System.Convert.ChangeType(qnoToolStripTextBox.Text, typeof(int)))), Form1.examcode);
            //    this.exam1TableAdapter.FillD(this.cCoption.exam1, ((int)(System.Convert.ChangeType(qnoToolStripTextBox.Text, typeof(int)))),  Form1.examcode);
          //      this.exam11TableAdapter.FillA(this.cCoption.exam11, ((int)(System.Convert.ChangeType(qnoToolStripTextBox.Text, typeof(int)))), Form1.examcode);
           //     this.exam12TableAdapter.FillB(this.cCoption.exam12, ((int)(System.Convert.ChangeType(qnoToolStripTextBox.Text, typeof(int)))), Form1.examcode);
            //    this.exam13TableAdapter.FillC(this.cCoption.exam13, ((int)(System.Convert.ChangeType(qnoToolStripTextBox.Text, typeof(int)))), Form1.examcode);
                groupBox1.Text = "Ques no. "+q.ToString();
                conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");


                SqlDataReader rdr = null;

                try
                {
                    // 2. Open the connection
                    conn.Open();

                    // 3. Pass the connection to a command object
                    //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    SqlCommand cmd = new SqlCommand("SELECT selectedoption FROM Result WHERE examcode ='" + Form1.examcode + "' And qno = '" + q + "' And userid = '" + Form1.userid + "'", conn);
                    //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string soption = (string)rdr[0];
                        if (soption == "a") checkBox1.Checked = true;
                        if (soption == "b") checkBox3.Checked = true;
                        if (soption == "c") checkBox2.Checked = true;
                        if (soption == "d") checkBox4.Checked = true;
                    }
                    else
                        MessageBox.Show("Error S002 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                  checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            if (q == 1)
                button6.Hide();
            else
            {
                q--;
                Change();
            }
            if (q == 1)
                button6.Hide();
            if (q != noq)
                button1.Show();
           /* checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Submit Your's Answers?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // 2. Open the connection
                    conn.Open();

                    // 3. Pass the connection to a command object
                    SqlCommand cmd = new SqlCommand("SELECT SUM(marks) AS Expr1 FROM result WHERE examcode ='" + Form1.examcode + "' And userid = '" + Form1.userid + "'", conn);


                    rdr = cmd.ExecuteReader();
                    totalmarks = 0;
                    if (rdr.Read())
                    {
                        //      MessageBox.Show(count.ToString());
                 //                   MessageBox.Show(rdr[0].ToString());
                        totalmarks = (double)rdr[0];
                    }
                    
                }
                catch (Exception ex)
                {
               //     MessageBox.Show("Server Error S0085", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
                studentDataTableAdapter1.InsertQuerynew(Form1.examcode, Form1.username, totalmarks, Form1.userid);
                Application.Exit();
            }
        }

        private void fillBytileToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBytileToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            s = s - 1;
            if(s == -1)
            {
                s = 59;
                m = m - 1;
            }
            if(m == -1)
            {
                m = 59;
                h = h - 1;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                // MessageBox.Show("Time up", "Time");
                timer1.Stop();
                MessageBox.Show("Time up", "time", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                try
                {
                    // 2. Open the connection
                    conn.Open();

                    // 3. Pass the connection to a command object
                    SqlCommand cmd = new SqlCommand("SELECT SUM(marks) AS Expr1 FROM result WHERE examcode ='" + Form1.examcode + "' And userid = '" + Form1.userid + "'", conn);


                    rdr = cmd.ExecuteReader();
                    totalmarks = 0;
                    if (rdr.Read())
                    {
                        //      MessageBox.Show(count.ToString());
                        //            MessageBox.Show(rdr[0].ToString());
                        totalmarks = (double)rdr[0];
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Server Error S0085", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                studentDataTableAdapter1.InsertQuerynew(Form1.examcode, Form1.username, totalmarks, Form1.userid);
                Application.Exit();
            }
         //   label6.Text = time.ToString();
            label2.Text = h.ToString();
            label4.Text = m.ToString();
            label7.Text = s.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if( checkBox1.Checked == false &&
            checkBox2.Checked == false &&
            checkBox3.Checked == false &&
            checkBox4.Checked == false )
            {
                MessageBox.Show("Select Your Answer !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button6.Show();
            string ch = null;
           
            if(true)
             { 
                conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");

                
                SqlDataReader rdr = null;

                try
                {
                    // 2. Open the connection
                    conn.Open();

                    // 3. Pass the connection to a command object
                  //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    SqlCommand cmd = new SqlCommand("SELECT correctoption FROM exam WHERE examcode ='"+ Form1.examcode + "' And qno = '"+q +"'", conn);
                 //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        correctoption = (string)rdr[0];
                    }   
                    else
                        MessageBox.Show("Error S002 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error s9989", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT marks , negmarks FROM exam WHERE examcode ='" + Form1.examcode.ToString() + "' And qno = '" + q + "'", conn);
                    //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rdr = cmd.ExecuteReader();
            //        MessageBox.Show("1", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (rdr.Read())
                    {
              //          MessageBox.Show(rdr[0].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        MessageBox.Show(rdr[1].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //         MessageBox.Show("2", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        marks = (double)rdr[0];
              //          MessageBox.Show("3", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        negmarks = (double)rdr[1];
              //          MessageBox.Show(rdr[1].ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Error S001 Reading Data neg", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch
                {
                    MessageBox.Show("Error S088 Reading Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                ch = null;
                if (checkBox1.Checked)
                {
                    ch = "a";
                    if (correctoption == "a") { correctness = 1; }
                    else correctness = 0;
                }
                if (checkBox3.Checked)
                {
                    ch = "b";
                    if (correctoption == "b") { correctness = 1; }
                    else correctness = 0;
                }
                if (checkBox2.Checked)
                {
                    ch = "c";
                    if (correctoption == "c") { correctness = 1; }
                    else correctness = 0;
                }
                if (checkBox4.Checked)
                {
                    ch = "d";
                    if (correctoption == "d") { correctness = 1; }
                    else correctness = 0;
                }
               
                //////////////////////////

                try
                {
                    // 2. Open the connection
                    conn.Open();

                    // 3. Pass the connection to a command object
                    //  MessageBox.Show("Start"+ Form1.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Result WHERE examcode ='" + Form1.examcode + "' And qno = '" + q + "' And userid = '" + Form1.userid + "'", conn);
                    //   MessageBox.Show("888", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rdr = cmd.ExecuteReader();

                    if (correctness == 0) marks = negmarks;
                    rdr.Read();
           //         MessageBox.Show(rdr[0].ToString(),"message");
                    if ((int)rdr[0] > 0)
                    {
                        //     MessageBox.Show("Answer Given", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultTableAdapter.UpdateQuerynew(marks, q, ch, correctoption, correctness.ToString(), q ,examcode , userid);
                      //  resultTableAdapter.UpdateQuerynew()
                    }
                    else
                        resultTableAdapter.InsertQuerynew(examcode, username, userid, marks, q, ch, correctoption, correctness.ToString());
                    
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                        {
                            Button b = (Button)c;
                            if (b.Tag.ToString().Equals(q.ToString()))
                            {
                                // b.Visible = false;
                                b.BackColor = Color.GreenYellow;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Check Server connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                /////////////////////////
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                q = q + 1;
                if(q == noq) button2.Show();
                if (q > noq)
                {
                    DialogResult result = MessageBox.Show("Submit Your's Answers?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // 2. Open the connection
                            conn.Open();

                            // 3. Pass the connection to a command object
                            SqlCommand cmd = new SqlCommand("SELECT SUM(marks) AS Expr1 FROM result WHERE examcode ='" + Form1.examcode + "' And userid = '" + Form1.userid + "'", conn);


                            rdr = cmd.ExecuteReader();

                            if (rdr.Read())
                            {
                           //      MessageBox.Show(count.ToString());
                           //            MessageBox.Show(rdr[0].ToString());
                                totalmarks = (double)rdr[0];
                            }
                            studentDataTableAdapter1.InsertQuerynew(Form1.examcode, Form1.username, totalmarks, Form1.userid);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Server Error S0085", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

                        this.Close();
                    }
                    else q--;
                }
                Change();

            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            button6.Show();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button b = (Button)c;
                    if (b.Tag.ToString().Equals(q.ToString()))
                    {
                        // b.Visible = false;
                        b.BackColor = Color.Blue;
                    }
                }
            }
            if (q >= noq)
            {
                button1.Hide(); button2.Show();
            }
            if (q != noq) 
            q = q + 1;
            if (q > noq) q--;
            if (q < noq) button1.Show();
            Change();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            /*   foreach (Control c in this.Controls)
               {
                   if (c is Button)
                   {
                       Button b = (Button)c;
                       if (b.Tag.ToString().Equals(q.ToString()))
                       {
                           // b.Visible = false;
                           b.BackColor = Color.Red;
                       }
                   }
               }    */
            if (q == noq)
            {
                button1.Hide();
                button2.Show();
            }
            else
            {
                q = q + 1;
            }
            if (q == noq)
            {
                button1.Hide();
                button2.Show();
            }
            if (q != 1)
                button6.Show();
            // button1.Click += new EventHandler(ButtonClickOneEvent);
            if (q > noq)
            {
                DialogResult result = MessageBox.Show("Submit Your's Answers?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // 2. Open the connection
                        conn.Open();

                        // 3. Pass the connection to a command object
                        SqlCommand cmd = new SqlCommand("SELECT SUM(marks) AS Expr1 FROM result WHERE examcode ='" + Form1.examcode + "' And userid = '" + Form1.userid + "'", conn);


                        rdr = cmd.ExecuteReader();

                        if (rdr.Read())
                        {
                            // MessageBox.Show(count.ToString());
                            //       MessageBox.Show(rdr[0].ToString());
                            totalmarks = (int)rdr[0];
                        }
                        studentDataTableAdapter1.InsertQuerynew(Form1.examcode, Form1.username, totalmarks, Form1.userid);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Server Error S0085", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

                    this.Close();
                }
                else q--;
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            Change();
        }
    }
}
