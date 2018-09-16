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
    public partial class AddQues : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        SqlDataReader rdr = null;
        int q = 1;
        string examcode;
        int examtime;
        public AddQues()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=192.168.43.185,49172,49172;Initial Catalog=CC;User ID=sa;Password=mypc107");
            try
            {
                // 2. Open the connection
                conn.Open();

            //   MessageBox.Show(questiontime.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SqlCommand cmd = new SqlCommand("SELECT MAX(qno) AS Expr1 FROM exam WHERE examcode ='" + questiontime.examcode + "'", conn);


                rdr = cmd.ExecuteReader();
                rdr.Read();
              //  MessageBox.Show("1"+ rdr[0].ToString());
                if (int.Parse(rdr[0].ToString()) > 0)
                {
                //    MessageBox.Show("2"+q.ToString());
                    q = (int)rdr[0];
                 //   MessageBox.Show("3"+q.ToString());
                   
                }

                q = q + 1;
            //    MessageBox.Show(q.ToString());
            }
            catch (Exception ex)
            {
             //   MessageBox.Show("Server Probleme Error S0098", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
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
        }

        private void AddQues_Load(object sender, EventArgs e)
        {
           
            comboBox1.Text = "a";
            questiontime qt = new questiontime();
             examtime = questiontime.examtime;
             examcode = questiontime.examcode;
//            MessageBox.Show(qt.examcode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            label8.Text = q.ToString();
            // TODO: This line of code loads data into the 'cCDataSet4.exam' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please Enter Question", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please Enter All Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            double f;
          //  questiontime qt = new questiontime();
          if (double.Parse(textBox6.Text) > 0)
            {
               f = double.Parse(textBox6.Text) * -1;
            }
          else f = double.Parse(textBox6.Text);
            examTableAdapter2.InsertQuery(questiontime.examcode, examtime.ToString(), q, richTextBox1.Text.ToString(), textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), comboBox1.Text.ToString(), int.Parse(textBox5.Text),f);
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "a";
            q++;
            label8.Text = q.ToString();
            set refress = new set();
            refress.Ref();
        }

       

        private void examBindingSource1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.examBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cCDataSet5);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void examBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void examBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 0 && e.KeyChar > 9 && e.KeyChar == '.')
            {
                MessageBox.Show("Please Enter Decimal Number or Natural Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
